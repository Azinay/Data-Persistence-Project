using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
  public string Name;
  public string BestName;
  public int BestScore = 0;

  public static DataManager Instance;

  void Awake()
  {
    Instance = this;
    DontDestroyOnLoad(gameObject);
  }

  [System.Serializable]
  class SaveData
  {
    public int BestScore;
    public string BestName;
  }

  void Start()
  {
    string path = $"{Application.persistentDataPath}/savefile.json";

    if(File.Exists(path))
    {
      string json = File.ReadAllText(path);
      SaveData data = JsonUtility.FromJson<SaveData>(json);

      BestScore = data.BestScore;
      BestName = data.BestName;
    }
  }

  public void BestScoreRecorder(int m_Points, string name)
  {
    if(m_Points > BestScore)
    {
      BestScore = m_Points;
      BestName = name;

      SaveData data = new SaveData();
      data.BestScore = BestScore;
      data.BestName = BestName;
      string json = JsonUtility.ToJson(data);

      File.WriteAllText($"{Application.persistentDataPath}/savefile.json", json);
    }
  }
}

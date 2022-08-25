using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class DataManager : MonoBehaviour
{
  public string Name;
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
  }

  void Start()
  {
    string path = $"{Application.persistentDataPath}/savefile.json";

    if(File.Exists(path))
    {
      string json = File.ReadAllText(path);
      SaveData data = JsonUtility.FromJson<SaveData>(json);

      BestScore = data.BestScore;
    }
  }

  public void BestScoreRecorder(int m_Points)
  {
    if(m_Points > BestScore)
    {
      BestScore = m_Points;

      SaveData data = new SaveData();
      data.BestScore = BestScore;
      string json = JsonUtility.ToJson(data);

      File.WriteAllText($"{Application.persistentDataPath}/savefile.json", json);
    }
  }
}

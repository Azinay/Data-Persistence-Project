using System.Collections;
using System.Collections.Generic;
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

  public void BestScoreRecorder(int m_Points)
  {
    if(m_Points > BestScore)
      BestScore = m_Points;
  }
}

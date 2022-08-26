using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

[DefaultExecutionOrder(100)]
public class MenuUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI name;
    public Text BestScoreText;

    void Start()
    {
      BestScoreText.text = $"Best Score : {DataManager.Instance.BestName} : {DataManager.Instance.BestScore}";
    }

    public void StartButton()
    {
        DataManager.Instance.Name = name.text;
        SceneManager.LoadScene(1);
    }

    public void ExitButton()
    {
      Application.Quit();
    }
}

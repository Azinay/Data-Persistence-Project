using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class MenuUIManager : MonoBehaviour
{
    // Start is called before the first frame update
    public TextMeshProUGUI name;

    public void StartButton()
    {
        DataManager.Instance.Name = name.text;
        SceneManager.LoadScene(1);
    }
}

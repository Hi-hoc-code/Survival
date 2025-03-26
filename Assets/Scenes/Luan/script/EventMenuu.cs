using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventMenuu : MonoBehaviour
{
    float timeOver;
    float timeMenu;
    public TextMeshProUGUI texttimemenu;
    // Start is called before the first frame update
    void Start()
    {
        PlayerPrefs.SetFloat("timemenu", timeMenu);
        timeMenu = PlayerPrefs.GetFloat("timemenu");
        timeOver = PlayerPrefs.GetFloat("timeover");
        if (timeOver > timeMenu)
        {
            timeMenu = timeOver;
            PlayerPrefs.SetFloat("timemenu", timeMenu);
            texttimemenu.text = "" + timeMenu.ToString("F2") + "s";
        }
    }

    public void play()
    {
        SceneManager.LoadScene(1);
    }
}

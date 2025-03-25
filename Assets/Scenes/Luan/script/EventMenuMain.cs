using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EventMenuMain : MonoBehaviour
{
    
    public void playAgain()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    public void pause()
    {
        Time.timeScale = 0;

    }
}

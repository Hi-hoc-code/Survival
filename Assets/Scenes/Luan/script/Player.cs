using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject panelGameover;
    public Clock clock;
    float timeover;
    // Start is called before the first frame update
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            timeover = clock.time;
            PlayerPrefs.SetFloat("timeover",timeover);
            Time.timeScale = 0;
            panelGameover.SetActive(true);
           
        }
    }
}

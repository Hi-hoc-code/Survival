using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject panelGameover;
    // Start is called before the first frame update
   

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Time.timeScale = 0;
            panelGameover.SetActive(true);
        }
    }
}

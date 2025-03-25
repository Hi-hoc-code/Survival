using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Clock : MonoBehaviour
{
   float time = 0f;
   public TextMeshProUGUI textClock;
 
    // Update is called once per frame
    void Update()
    {
       time += Time.deltaTime;
        textClock.text = time.ToString("F2"); // Định dạng chuỗi với 2 chữ số thập phân
    }
}

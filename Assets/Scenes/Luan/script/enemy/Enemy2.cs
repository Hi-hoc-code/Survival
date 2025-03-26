using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy2 : MonoBehaviour
{
     int rotationn;
     float time =3f;
    // Start is called before the first frame update
    void Start()
    {
        rotationn = Random.Range(0, 180);
        transform.rotation= Quaternion.Euler(0,0,rotationn);
    }
    // Update is called once per frame
    void Update()
    {
        time -= Time.deltaTime;
        if (time < 0)
        {
            transform.localScale= new Vector3(22.6f, 0.15f,0);
            Collider2D collider = GetComponent<Collider2D>();
                // Mở Collider
                collider.enabled = true;
            Destroy(gameObject,0.5f);
        }
    }
}

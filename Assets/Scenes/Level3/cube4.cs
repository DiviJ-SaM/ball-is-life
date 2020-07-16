using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class cube4 : MonoBehaviour
{
    Vector3 pos = new Vector3(-12, -2, 5);
    int n = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (n == 1)
        {
            pos.x += 20f * Time.deltaTime;
            transform.position = pos;
            if (pos.x >= 17)
            {
                n = 2;
            }
        }

        if (n == 2)
        {
            pos.y -= 20f * Time.deltaTime;
            transform.position = pos;
            if (pos.y <= -6)
            {
                n = 3;
            }
        }
        if (n == 3)
        {
            pos.x -= 20f * Time.deltaTime;
            transform.position = pos;
            if (pos.x <= -12)
            {
                n = 4;
            }
        }

        if (n == 4)
        {
            pos.y += 20f * Time.deltaTime;
            transform.position = pos;
            if (pos.y >= -3)
            {
                n = 1;
            }
        }
    }
    
}

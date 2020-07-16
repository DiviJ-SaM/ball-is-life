using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sp2 : MonoBehaviour
{
    Vector3 pos = new Vector3(54.3f, -5.8f, -34);
    int n = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 19f;
        if (n == 1)
        {
            pos.x += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x >= 54)
            {
                n = 2;
            }
        }

        if (n == 2)
        {
            pos.y -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y <= -5.5)
            {
                n = 3;
            }
        }
        if (n == 3)
        {
            pos.x -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x <= 44)
            {
                n = 4;
            }
        }

        if (n == 4)
        {
            pos.y += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y >= 9)
            {
                n = 1;
            }
        }
    }
    
}

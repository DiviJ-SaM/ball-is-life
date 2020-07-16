using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sp4 : MonoBehaviour
{
    Vector3 pos = new Vector3(73,-5,-34);
    int n = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 15f;
        if (n == 1)
        {
            pos.x += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x >= 70)
            {
                n = 2;
            }
        }

        if (n == 2)
        {
            pos.y -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y <= -5)
            {
                n = 3;
            }
        }
        if (n == 3)
        {
            pos.x -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x <= 62)
            {
                n = 4;
            }
        }

        if (n == 4)
        {
            pos.y += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y >= 0)
            {
                n = 1;
            }
        }
    }
   
}

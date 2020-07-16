using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sp1 : MonoBehaviour
{
    Vector3 pos = new Vector3(-2.63f, -0.52f, 0);
    int n = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10f;
        if (n == 1)
        {
            pos.x += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x >= 3)
            {
                n = 2;
            }
        }

        if (n == 2)
        {
            pos.y -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y <= -3.41)
            {
                n = 3;
            }
        }
        if (n == 3)
        {
            pos.x -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x <= -2.63)
            {
                n = 4;
            }
        }

        if (n == 4)
        {
            pos.y += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y >= -0.6)
            {
                n = 1;
            }
        }
    }
   

}

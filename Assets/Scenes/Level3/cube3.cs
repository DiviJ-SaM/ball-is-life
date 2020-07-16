using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cube3 : MonoBehaviour
{
    Vector3 pos = new Vector3(-15,5,5);
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
            pos.y += 9f * Time.deltaTime;
            transform.position = pos;
            if (pos.y >= 4.9)
            {
                n = 2;
            }
        }
        if (n == 2)
        {
            pos.y -= 9f * Time.deltaTime;
            transform.position = pos;
            if (pos.y <= -0.5)
            {
                n = 1;
            }
        }
    }
   
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cube11 : MonoBehaviour
{
    Vector3 pos = new Vector3(-9, 8, 5);
    int n = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 8f;
        if (n == 1)
        {
            pos.y += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y >= 16)
            {
                n = 2;
            }
        }

        if (n == 2)
        {
            pos.y -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y <= 8.2)
            {
                n = 1;
            }
        }
    }
    
}

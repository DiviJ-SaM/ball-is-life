using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cube6 : MonoBehaviour
{
    Vector3 pos = new Vector3(3,4,5);
    int n = 1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 20f;
        if (n == 1)
        {
            pos.x += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x >= 32)
            {
                n = 2;
            }
        }
        
        if (n == 2)
        {
            pos.x -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.x <= 3)
            {
                n = 1;
            }
        }
    }
    
}

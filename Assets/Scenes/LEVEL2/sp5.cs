using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sp5 : MonoBehaviour
{
    Vector3 pos = new Vector3(35,2,-34);
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
            pos.x += 15f * Time.deltaTime;
            transform.position = pos;
            if (pos.x >= 35.5)
            {
                n = 2;
            }
        }

        
        
        if (n == 2)
        {
            pos.x -= 15f * Time.deltaTime;
            transform.position = pos;
            if (pos.x <= 25.7)
            {
                n = 1;
            }
        }

        
    
    }
    
}

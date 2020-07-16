using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sp6 : MonoBehaviour
{
    Vector3 pos = new Vector3(68,6,-34);
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
            pos.x += 10f * Time.deltaTime;
            transform.position = pos;
            if (pos.x >= 79)
            {
                n = 2;
            }
        }
        if (n == 2)
        {
            pos.x -= 10f * Time.deltaTime;
            transform.position = pos;
            if (pos.x <= 65)
            {
                n = 1;
            }
        }
    }
   
}

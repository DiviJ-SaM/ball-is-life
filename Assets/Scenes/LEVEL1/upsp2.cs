using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class upsp2 : MonoBehaviour
{
    Vector3 pos = new Vector3(5.28f, 5.23f, 0);
    int n = 1;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        float speed = 7f;
        if (n == 1)
        {
            pos.y += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y >= 5.2)
            {
                n = 2;
            }
        }

        if (n == 2)
        {
            pos.y -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y <= 2)
            {
                n = 1;
            }
        }
    }
   

}

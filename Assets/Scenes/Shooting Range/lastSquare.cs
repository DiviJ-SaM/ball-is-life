using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lastSquare : MonoBehaviour
{
    Vector3 pos = new Vector3(26.5f,35.83f,16.089f);
    int n = 1;
    float speed = 7f;
    int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (n == 1)
        {
            pos.y += speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y >= 36)
            {
                n = 2;
            }
        }
        if (n == 2)
        {
            pos.y -= speed * Time.deltaTime;
            transform.position = pos;
            if (pos.y <= 30)
            {
                n = 1;
            }
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "PlayerBullet")
        {
            health--;

        }
        if(health<1)
        {
            Destroy(this.gameObject);
        }
    }
}

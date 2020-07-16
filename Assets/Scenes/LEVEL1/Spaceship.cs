using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Spaceship  : MonoBehaviour
{
    int pos;
    int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 7f;
        Vector3 pos = transform.position;
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;
        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;
        }
        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;
        }
        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;
        }
        transform.position = pos;
    }
    void OnCollisionEnter(Collision win)
    {
        if (win.gameObject.tag == "Guard")
        {
            this.transform.position = new Vector3(-8.1f, -2.9f, -0.37f);
            health--;

            
        }
        if (win.gameObject.tag == "UpGuards")
        {
            this.transform.position = new Vector3(-0.2f, 3.12f, -0.37f);
            health--;
            
        }
        if (health < 1)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Loser");
        }
        if (win.gameObject.tag == "Door")
        {
            SceneManager.LoadScene("2");
        }

    }
}

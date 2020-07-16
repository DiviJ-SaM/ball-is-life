using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player2 : MonoBehaviour
{
    public AudioSource Dope;
    int pos;
    int health=3;
    // Start is called before the first frame update
    void Start()
    {
        Dope = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 11f;
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
        if(win.gameObject.tag=="Guard")
        {
            this.transform.position = new Vector3(28.3f, -6.6f, -34.5f);
            health--;

            Dope.Play();
        }
        if (health < 1)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Loser");
        }
        if(win.gameObject.tag=="Dooor")
        {
            SceneManager.LoadScene("3");
        }
    }
}

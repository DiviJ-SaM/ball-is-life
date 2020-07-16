using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player3 : MonoBehaviour
{
    public AudioSource Dope;
    int pos;
    int health = 3;
    // Start is called before the first frame update
    void Start()
    {
        Dope = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 pos = transform.position;
        float speed = 10f;
        if (Input.GetKey("w"))
        {
            pos.y += speed * Time.deltaTime;

        }
        if (Input.GetKey("s"))
        {
            pos.y -= speed * Time.deltaTime;

        }

        if (Input.GetKey("a"))
        {
            pos.x -= speed * Time.deltaTime;

        }

        if (Input.GetKey("d"))
        {
            pos.x += speed * Time.deltaTime;

        }
        transform.position = pos;
    }
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Door3")
        {
            SceneManager.LoadScene("Practice");
        }
        if (other.gameObject.tag == "L4DownGuards")
        {
            this.transform.position=new Vector3(-6.68f,2,4.9f);
            health--;
            Dope.Play();
        }
        if (other.gameObject.tag == "L4UpGuards")
        {
            this.transform.position = new Vector3(17.9f, 12.5f, 4.9f);
            health--;
            Dope.Play();
        }


        if (other.gameObject.tag == "GreenD1")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "GreenD2")
        {
            Destroy(other.gameObject);
        }
        if (other.gameObject.tag == "GreenD3")
        {
            Destroy(other.gameObject);
        }
        if(other.gameObject.tag=="Guard")
        {
            this.transform.position = new Vector3(-26.43f, -1.47f, 4.9f);
            health--;
            Dope.Play();

        }
        if(health<1)
        {
            Destroy(this.gameObject);
            SceneManager.LoadScene("Loser");
        }

    }
}


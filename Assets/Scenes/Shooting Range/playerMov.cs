using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerMov : MonoBehaviour
   
{
    int pos;
    public AudioSource Dope;
    // Start is called before the first frame update
    void Start()
    {
        Dope = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float speed = 10f;
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
        if(Input.GetKey(KeyCode.Space))
        {
            Dope.Play();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag=="Bruh")
        {
            SceneManager.LoadScene("Winner");
        }
    }
   
}

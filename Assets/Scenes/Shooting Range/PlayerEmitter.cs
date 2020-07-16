using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEmitter : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 545f;
    float timer = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (Input.GetKey(KeyCode.Space)&&timer >0.2)
        {
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(Vector3.right * speed);
            timer=0;
        }
    }
}

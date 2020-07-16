
using UnityEngine;

public class BossBullets : MonoBehaviour
{
    public GameObject bullet;
    public float speed = 25f;
    public float timer = 0;
    // Start is called before the first frame update


    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 1)
        {
            GameObject instBullet = Instantiate(bullet, transform.position, Quaternion.identity) as GameObject;
            Rigidbody instBulletRigidbody = instBullet.GetComponent<Rigidbody>();
            instBulletRigidbody.AddForce(Vector3.left * speed);
            timer = 0;

        }
    }
}
  

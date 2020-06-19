using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PistolBullet : MonoBehaviour
{
    [SerializeField]
    [Range(15,50)]
    public float speed = 8f;
    //without force
    //transform.Translate(Vector2.right* Hspeed* Time.deltaTime);
    private void Start()
    {
        float randx = Random.Range(-0.9f, 0.9f);
        float randy = Random.Range(-0.9f, 0.9f);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(0, 0, 0);
        rb.velocity += transform.forward * speed;

        Invoke("DeSpawn", 3.0f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.SendMessage("TakeDamage",5, SendMessageOptions.DontRequireReceiver);
    }
    public void DeSpawn()
    {
        Destroy(gameObject);
    }
}

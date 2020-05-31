using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    [SerializeField]
    [Range(15,50)]
    private float speed = 8f;
    //without force
    //transform.Translate(Vector2.right* Hspeed* Time.deltaTime);
    private void Start()
    {
        float randx = Random.Range(-1.05f, 1.5f);
        float randy = Random.Range(-1.05f, 1.5f);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = new Vector3(randx, randy, 0);
        rb.velocity += transform.forward * speed;

        Invoke("DeSpawn", 3.0f);
    }
    private void OnCollisionEnter(Collision collision)
    {
        collision.transform.SendMessage("TakeDamage", SendMessageOptions.DontRequireReceiver);
    }
    public void DeSpawn()
    {
        Destroy(gameObject);
    }
}

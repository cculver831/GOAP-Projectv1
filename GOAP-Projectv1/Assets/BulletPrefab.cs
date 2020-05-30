using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    [SerializeField]
    [Range(15,25)]
    private float speed = 8f;
    public GameObject bulletSpawn;
    //without force
    //transform.Translate(Vector2.right* Hspeed* Time.deltaTime);
    private void Start()
    {
        int randx = Random.Range(0, 20);
        int randy = Random.Range(0, 20);
        Rigidbody rb = GetComponent<Rigidbody>();
        rb.velocity = transform.forward * speed;
    }
}

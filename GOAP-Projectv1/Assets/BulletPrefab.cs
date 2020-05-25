using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletPrefab : MonoBehaviour
{
    private float speed = 8f;


    private void Update()
    {
        //Make Bullet move forward
        transform.position += transform.forward * speed * Time.deltaTime;
    }
}

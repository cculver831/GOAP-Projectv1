using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pistol : MonoBehaviour
{
    public GameObject bullet;
    public GameObject BulletSpawn;
    public float coolDownPeriodInSeconds = 0.5f;
    private float timeStamp;

    // Update is called once per frame
    void Update()
    {
        Fire();
    }
    void Fire()
    {

        if (Input.GetButtonDown("Fire1") && timeStamp <= Time.time)
        {
            GameObject bulletObject = Instantiate(bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
            timeStamp = Time.time + coolDownPeriodInSeconds;
        }
    }
}

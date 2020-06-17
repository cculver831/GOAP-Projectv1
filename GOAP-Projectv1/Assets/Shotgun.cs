using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shotgun : MonoBehaviour
{
    public int ShotCount = 12;
    public float spreadAngle;

    List<Quaternion> shots;
    public float coolDownPeriodInSeconds = 0.5f;
    private float timeStamp;
    public GameObject bullet;
    public Transform BulletSpawn;

    // Start is called before the first frame update
    void Awake()
    {
        //shots = new List<Quaternion>(new Quaternion[ShotCount]);

    }

    // Update is called once per frame  && timeStamp <= Time.time
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && timeStamp <= Time.time)
        {
            Fire();

        }
    }
    void Fire()
    {

        for (var i = 0; i < ShotCount; i++)
        {
            var pelletRot = transform.rotation;
            pelletRot.x += Random.Range(-spreadAngle, spreadAngle);
            pelletRot.y += Random.Range(-spreadAngle, spreadAngle);
            var pellet = Instantiate(bullet, BulletSpawn.transform.position, pelletRot);
            Rigidbody rb = pellet.GetComponent<Rigidbody>();
            rb.velocity = transform.forward;
        }
        
        timeStamp = Time.time + coolDownPeriodInSeconds;

    }
}

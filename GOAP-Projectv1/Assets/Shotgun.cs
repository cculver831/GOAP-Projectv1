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


    float variance = 1.0f;
    float distance = 10.0f;
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

        //for (var i = 0; i < ShotCount; i++)
        //{
        //    var pelletRot = transform.rotation;
        //    pelletRot.x += Random.Range(-spreadAngle, spreadAngle);
        //    pelletRot.y += Random.Range(-spreadAngle, spreadAngle);
        //    var pellet = Instantiate(bullet, BulletSpawn.transform.position, pelletRot);
        //    Rigidbody rb = pellet.GetComponent<Rigidbody>();
        //    rb.velocity = transform.forward;
        //}
        for (var i = 0; i < 20; i++)
        {
            var v3Offset = transform.up * Random.Range(0.0f, variance);
            v3Offset = Quaternion.AngleAxis(Random.Range(0.0f, 360.0f), transform.forward) * v3Offset;
            var v3Hit = transform.forward * distance + v3Offset;

            // Position an object to test pattern
            var tr = GameObject.CreatePrimitive(PrimitiveType.Sphere).transform;
            tr.localScale = new Vector3(0.1f, 0.1f, 0.1f);
            tr.position = v3Hit;
            timeStamp = Time.time + coolDownPeriodInSeconds;
        }
    }
}

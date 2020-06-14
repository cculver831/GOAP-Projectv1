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
        shots = new List<Quaternion>(new Quaternion[ShotCount]);

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
        
        for(int i = 0; i < ShotCount; i++)
        {
            int l = Random.Range(-1, 1);
            shots[i] = Random.rotation;
            GameObject pellet = Instantiate(bullet, BulletSpawn.position, BulletSpawn.rotation);
            pellet.transform.rotation = Quaternion.RotateTowards(transform.rotation, shots[i], spreadAngle); //declumps all the bullets

            timeStamp = Time.time + coolDownPeriodInSeconds;
            
        }
    }
}

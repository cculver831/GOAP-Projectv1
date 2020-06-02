using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : GAction
{
    //Might need to get player into inventory for proper rotation
    public GameObject BulletSpawn;
    public GameObject bullet;

    public override bool PrePerform()
    {
        Debug.Log("I have a weapon and I want to shoot you");
        return true;
    }

    public override bool PostPerform()
    {
        Invoke("Fire", 0.5f);
        
        //bulletObject.transform.position += transform.position + BulletSpawn.transform.forward;
       // Debug.Log("I am attacking you");
        return true;
    }
    void Fire ()
    {
        GameObject bulletObject = Instantiate(bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : GAction
{
    public GameObject BulletSpawn;
    public GameObject bullet;


    public override bool PrePerform()
    {


        //Invoke("Fire", 0.5f);
        return true;
    }
    private void Start()
    {
        
    }
    public override bool PostPerform()
    {
        //beliefs.RemoveState("SeesPlayer");
        //CancelInvoke("Fire");
        GameObject bulletObject = Instantiate(bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);
        return true;
    }
    void Fire()
    {
       
        
    }
}

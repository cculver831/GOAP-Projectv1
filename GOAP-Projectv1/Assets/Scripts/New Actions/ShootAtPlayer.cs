using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : GAction
{
    public GameObject BulletSpawn;
    public GameObject bullet;
    private int Ammo = 6;

    public override bool PrePerform()
    {

        if(Ammo > 0)
        {
            beliefs.AddStateOnce("HasNoAmmo", 0);
            return true;
        }
          
        else
        {
            return false;
        }
        //Invoke("Fire", 0.5f);

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

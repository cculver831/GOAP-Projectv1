﻿using System.Collections;
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
        
        GameObject bulletObject = Instantiate(bullet, BulletSpawn.transform.position,BulletSpawn.transform.rotation);
        //bulletObject.transform.position += transform.position + BulletSpawn.transform.forward;
       // Debug.Log("I am attacking you");
        return true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : GAction
{
    public GameObject BulletSpawn;
    public GameObject bullet;

    public override bool PrePerform()
    {
        //beliefs.ModifyState("JustSawPlayer", 0);
        //Debug.Log("I have a weapon and I want to shoot you");
        return true;
    }

    public override bool PostPerform()
    {
        //beliefs.ModifyState("JustSawPlayer", 0);
        GameObject bulletObject = Instantiate(bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);

        return true;
    }
}

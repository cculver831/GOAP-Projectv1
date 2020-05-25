using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : GAction
{
    public GameObject BulletSpawn;
    public GameObject bullet;
    public override bool PrePerform()
    {
        Debug.Log("I have a weapon and I want to shoot you");
        return true;
    }

    public override bool PostPerform()
    {
        GameObject bulletObject = Instantiate(bullet);
        bulletObject.transform.position = BulletSpawn.transform.position;
        Debug.Log("I am attacking you");
        return true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeAttack : GAction
{
    private GameObject t;

    public override bool PrePerform()
    {
       
        return true;
    }

    public override bool PostPerform()
    {
        //beliefs.ModifyState("JustSawPlayer", 0);
        //GameObject bulletObject = Instantiate(bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);

        return true;
    }
}

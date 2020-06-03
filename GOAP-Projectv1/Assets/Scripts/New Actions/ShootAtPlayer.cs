using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : GAction
{
    public GameObject BulletSpawn;
    public GameObject bullet;

    public override bool PrePerform()
    {
        //Debug.Log("I have a weapon and I want to shoot you");
        return true;
    }
    private void Update()
    {
        if (beliefs.HasState("Doesn'tSeePlayer") && this.running)
        {

            finishEarly = true;
            
        }

    }
    public override bool PostPerform()
    {
        beliefs.ModifyState("JustSawPlayer", 0);
        GameObject bulletObject = Instantiate(bullet, BulletSpawn.transform.position, BulletSpawn.transform.rotation);

        return true;
    }
}

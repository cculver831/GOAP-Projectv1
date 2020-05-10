using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootAtPlayer : GAction
{
    public override bool PrePerform()
    {
        Debug.Log("I have a weapon and I want to shoot you");
        return true;
    }

    public override bool PostPerform()
    {
        Debug.Log("I am attacking you");
        return true;
    }
}

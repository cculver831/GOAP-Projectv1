using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : GAction
{
    //Might need to get player into inventory for proper rotation
    public GameObject[] PatrolRoute;
    public override bool PrePerform()
    {

        return true;
    }

    public override bool PostPerform()
    {

        return true;
    }
}

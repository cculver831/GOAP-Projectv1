using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : GAction
{
    //Change destination everytime
    public GameObject waypoints;
    
    public override bool PrePerform()
    {
        return true;
    }
    private void Update()
    {

    }
    public override bool PostPerform()
    {
        LookForPlayer();
        return true;
    }
    void LookForPlayer()
    {

    }
}

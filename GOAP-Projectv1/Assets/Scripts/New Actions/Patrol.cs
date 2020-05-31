using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : GAction
{

    public override bool PrePerform()
    {
        return true;
    }
    //private void Update()
    //{
    //    for (int i = 0; i < waypoints.transform.childCount; i++)
    //    {
    //        Debug.Log("Child Count of Ways Points: " + i);
    //    }
    //}
    public override bool PostPerform()
    {
        LookForPlayer();

        
        return true;
    }
    void LookForPlayer()
    {

    }
}

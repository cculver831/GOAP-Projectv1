using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToPlayer : GAction
{
    public override bool PrePerform()
    {
    if(beliefs.HasState("SeesPlayer"))
        {
            Debug.Log("I See You");
            return true;
        }
        
        else
        {
            return false;
        }
    }

    public override bool PostPerform()
    {
        Debug.Log("I am attacking you");
        return true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToLastLocation : GAction
{
    public override bool PrePerform()
    {

        Debug.Log("I'ma pull up on ya, son");
        return true;
    }

    public override bool PostPerform()
    {
        
        return true;
    }
}

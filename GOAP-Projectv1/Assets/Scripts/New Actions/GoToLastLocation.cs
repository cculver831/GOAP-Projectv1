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
    private void Update()
    {
        if (beliefs.HasState("SeesPlayer") && this.running)
        {
            
            finishEarly = true;
            Debug.Log("I stopped looking for you");
           
        }

    }
    public override bool PostPerform()
    {
        
        beliefs.RemoveState("JustSawPlayer");
        beliefs.ModifyState("Doesn'tSeePlayer",0);
        Debug.Log("I lost you");
        return true;
    }
}

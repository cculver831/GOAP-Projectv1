using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AgressivePatrol : GAction
{
   
    public override bool PrePerform()
    {

        return true;
    }
    private void Update()
    {
       if(beliefs.HasState("SeesPlayer")&& this.GetComponent<GAgent>().currentAction.actionName == "Agressive Patrol")
        {
            this.GetComponent<GAgent>().CancelAction();
            Debug.Log("I stopped running");
        }
 
    }

    public override bool PostPerform()
    {
        LookForPlayer();

        Debug.Log("Agressive Patrol Active");
        return true;


        //return true;
    }
    void LookForPlayer()
    {

    }

  
}

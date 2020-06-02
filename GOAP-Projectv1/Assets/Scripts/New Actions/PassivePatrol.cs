using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PassivePatrol : GAction
{
   
    public override bool PrePerform()
    {

        return true;
    }

    public override bool PostPerform()
    {
        LookForPlayer();

        return true;


        //return true;
    }
    void LookForPlayer()
    {

    }

  
}

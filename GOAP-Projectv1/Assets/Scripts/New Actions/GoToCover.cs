﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoToCover : GAction
{
    
    public override bool PrePerform()
    {

        // Get a free toilet
        target = GWorld.Instance.GetQueue("covers").RemoveResource();

        //Debug.Log("Cover Found");
        // Check we got a toilet
        if (target == null)
        {
            Debug.Log("This bitch empty");
            return false;

        }
        
        // Add it to the inventory
        inventory.AddItem(target);
        // Remove it's availability from the world
        GWorld.Instance.GetWorld().ModifyState("FreeCover", -1);
        return true;
    }

    public override bool PostPerform()
    {

        // Return the toilet to the pool
        //GWorld.Instance.GetQueue("covers").AddResource(target);
        // Remove the toilet from the list
        //inventory.RemoveItem(target);
        // Give the toilet back to the world
        //GWorld.Instance.GetWorld().ModifyState("FreeCover", 1);
        //beliefs.RemoveState("safe");
        Debug.Log("I'm behind cover");
        return true;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GetWeapon : GAction
{
    public override bool PrePerform()
    {

        // Get a free toilet
        target = GWorld.Instance.GetQueue("weapons").RemoveResource();

        if (target == null)
        {
            return false;

        }

        // Add it to the inventory
        
        // Remove it's availability from the world
        GWorld.Instance.GetWorld().ModifyState("FreeWeapon", -1);
        return true;
    }

    public override bool PostPerform()
    {

        beliefs.ModifyState("HasWeapon", 0);
        beliefs.RemoveState("activated");
        Debug.Log("Weapon acquired");
        inventory.AddItem(target);
        return true;
    }
}

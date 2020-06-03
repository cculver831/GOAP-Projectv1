using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SearchForPlayer : GAction
{
    public override bool PrePerform()
    {
        target = GetComponent<Enemy>().lastLocation;
        //Debug.Log("I see you");
        return true;
    }

    public override bool PostPerform()
    {
        //Debug.Log("I am attacking you");
        return true;
    }
}

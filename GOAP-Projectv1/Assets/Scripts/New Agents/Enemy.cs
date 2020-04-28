using UnityEngine;


/*
 * Basic Enemy class that will be added on as project expands
 **/
public class Enemy : GAgent
{

    new void Start()
    {

        // Call the base start
        base.Start();
        // Set up the subgoal "isWaiting"
        SubGoal s1 = new SubGoal("isCovered", 1, true);
        // Add it to the goals
        goals.Add(s1, 3);

   
        //Invoke("NeedRelief", Random.Range(2.0f, 5.0f));
    }

    //void NeedRelief()
    //{

    //    beliefs.ModifyState("busting", 0);
    //    // Call the get NeedRelief method over and over at random times to make the agent
    //    // go to the loo again
    //    Invoke("NeedRelief", Random.Range(2.0f, 5.0f));
    //}

}

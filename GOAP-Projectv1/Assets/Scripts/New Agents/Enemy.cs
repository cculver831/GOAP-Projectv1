using UnityEngine;


/*
 * Basic Enemy class that will be added on as project expands
 **/
public class Enemy : GAgent
{
    public int health = 2;
    new void Start()
    {
        
        // Call the base start
        base.Start();
        // Set up the subgoal "isWaiting"
        SubGoal s1 = new SubGoal("isCovered", 1, true);
        // Add it to the goals
        goals.Add(s1, 5);
        SubGoal s2 = new SubGoal("ApproachPlayer", 1, false);
        goals.Add(s2,1);
        //Invoke("NeedRelief", Random.Range(2.0f, 5.0f));
    }

    public Transform target;

    float rotationSpeed = 2.0f;
    float visDist = 20.0f;
    float visAngle = 90.0f;


    // Update is called once per frame
    void Update()
    {
        // direction  is the target( player) location in the world 'compared' to this object's own position in the world
        Vector3 direction = target.position - transform.position;
        // angle is the angle this object is from the target
        float angle = Vector3.Angle(direction, transform.forward);

        if (direction.magnitude < visDist && angle < visAngle)
        {
            direction.y = 0;

            //turns towards player
            transform.rotation = Quaternion.Slerp(transform.rotation,
                Quaternion.LookRotation(direction), Time.deltaTime * 10);
                beliefs.ModifyState("SeesPlayer", 0); //adds sees player to belief state
            beliefs.ModifyState("HasWeapon", 0);
           // Debug.Log("I see you");


        }
        float low = getHealth()/2;
        if(health <= 5)
        {
            beliefs.ModifyState("isHurt", 0);
            Debug.Log(" I'm hurt");
        }
    }

    int getHealth()
    {
        return health;
    }
}

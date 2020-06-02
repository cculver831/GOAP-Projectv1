using UnityEngine;
using UnityEngine.AI;


/*
 * Basic Enemy class that will be added on as project expands
 **/
public class Enemy : GAgent
{
    //Text for visuals
    public GameObject Enemyobj;
    private static GameObject Text; 
    private float meleeRange = 3.0f;
    public int health = 2;
    public NavMeshAgent agent;
    private bool doOnce = true;
    public GameObject lastLocation;
    //public Waypoint wp;
    
    new void Start()
    {
        Text = Enemyobj.transform.Find("Floating Text").gameObject;
        // Call the base start
        base.Start();
        // Set up the subgoal "isWaiting"
        SubGoal s1 = new SubGoal("Safe", 6, true);
        // Add it to the goals
        goals.Add(s1, 6);
        SubGoal s2 = new SubGoal("Dodge", 1, false);
        goals.Add(s2, 1);
        SubGoal s3 = new SubGoal("KillPlayer", 5, false);
        goals.Add(s3, 5);
        SubGoal s4 = new SubGoal("Armed",7, true);
        goals.Add(s4, 7);
        SubGoal s5 = new SubGoal("Patrol", 5, false);
        goals.Add(s5, 5);

        agent = this.gameObject.GetComponent<NavMeshAgent>();
        beliefs.ModifyState("NotActivated", 0);
    }


    //Variables for Enemy Vision
    public Transform target;
    float visDist = 35.0f;
    float visAngle = 90.0f;
    float speed = 20.0f;
    //
    // Update is called once per frame
    void Update()
    {
        EnemySight();
        CheckHealth();
        CheckMelee();
    }

    void EnemySight()
    {

        // direction  is the target( player) location in the world 'compared' to this object's own position in the world
        Vector3 direction = target.position - transform.position;
        // angle is the angle this object is from the target
        float angle = Vector3.Angle(direction, transform.forward);

        //will need to be modified for player cover
        //add wall detection
        if (direction.magnitude < visDist && angle < visAngle)
        {
            direction.y = 0;
            ShowText();
            //turns towards player
            // Determine which direction to rotate towards
            Vector3 targetDirection = target.position - transform.position;

            // The step size is equal to speed times frame time.
            float singleStep = speed * Time.deltaTime;

            // Rotate the forward vector towards the target direction by one step
            Vector3 newDirection = Vector3.RotateTowards(transform.forward, targetDirection, singleStep, 0.0f);

            // Draw a ray pointing at our target in
            Debug.DrawRay(transform.position, newDirection, Color.red);

            // Calculate a rotation a step closer to the target and applies rotation to this object
            transform.rotation = Quaternion.LookRotation(newDirection);
            lastLocation.transform.position = target.transform.position;
            //end of enemy Rotate
            beliefs.ModifyState("SeesPlayer", 0); //adds sees player to belief state
            beliefs.RemoveState("Doesn'tSeePlayer"); 
        }
        
        else
        {
            //turns off text when player is no longer seen
            beliefs.RemoveState("SeesPlayer");
            beliefs.ModifyState("Doesn'tSeePlayer", 0);
            Text.SetActive(false); 
        }
    }
    void ShowText()
    {
            Text.SetActive(true);
            //Debug.Log("Showing Text");

    }
    void CheckHealth()
    {
        if (health < 10)
        {
            if(doOnce)
            {
                beliefs.ModifyState("activated", 0);
                Debug.Log("Done Once");
                beliefs.RemoveState("NotActivated");
                doOnce = false;
            }
            beliefs.ModifyState("isHurt", 0);
            
            //Debug.Log("Agent Activated");
            //Debug.Log(" I'm hurt");
        }
    }
    void CheckMelee()
    {
        if (Mathf.Abs(target.position.magnitude - transform.position.magnitude) <= meleeRange)
        {
            //Debug.Log("I can punch you, but I don't know how :/");
            beliefs.ModifyState("isinMeleeRange", 0);
        }
        else
        {
            beliefs.RemoveState("isinMeleeRange");
        }

    }
    public void TakeDamage()
    {
        Debug.Log("Ouch! I took damage");
        health -= 2;
    }
}

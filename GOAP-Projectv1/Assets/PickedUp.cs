using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickedUp : MonoBehaviour
{
    public static int test;
    private void Update()
    {

      
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            Debug.Log("It's touching me!!!)");
            GetComponent<BoxCollider>().isTrigger = true;
            //collision.transform.parent = this.transform;
            //Destroy(gameObject, 1);
            //object1 is now the child of object2
        }
        Debug.Log("Something Touched me!");
    }

}

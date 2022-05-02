using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockCollision : MonoBehaviour
{
    public float score = 25;

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "PhysicsBlock") ;
        {
            //Destroy(col.gameObject);
            //Debug.Log("Projectile Destroyed");
            score -= 1;
            Debug.Log(score);
        }
        if (score == 0)
        {
            Destroy(this.gameObject);
            Debug.Log("Room Destroyed");
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}

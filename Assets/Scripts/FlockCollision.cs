using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockCollision : MonoBehaviour
{
    private float score = 1f;
    public Material Good;
    public Material Bad;

    private void OnCollisionEnter(Collision col)
    {
        MeshRenderer mr = this.GetComponent<MeshRenderer>();


        if (col.gameObject.name == "PhysicsBlock") ;
        {
            //Destroy(col.gameObject);
            //Debug.Log("Projectile Destroyed");
            score -= 1;
            Debug.Log(score);
        }
        if (score == 25)
        {
            mr.material = Bad;
            //Destroy(this.gameObject);
            //Debug.Log("Room Destroyed");
        }
        if (score == 5)
        {
            mr.material = Good;
        }
    }

    // Update is called once per frame
    private void Update()
    {
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlockCollision : MonoBehaviour
{
    private GameObject block;

    public Material Good;
    public Material Bad;
    //public float Score = 1f;

    private List<GameObject> Blocks = new List<GameObject>();
    


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            CompareProportion();
        }
    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "AirBlock") ;
        {
            Blocks.Add(block);
        }
        if (col.gameObject.tag == "LightBlock") ;
        {
            Blocks.Add(block);
        }
    }


    private void CompareProportion()
    {
        MeshRenderer mr = this.GetComponent<MeshRenderer>();
        int a = 0;
        int b = 0;

        for (int i = 0; i < Blocks.Count; i++)
        {
            if (Blocks[i].tag == "AirBlock")
            {
                a++;
            }
            if (b / a == 2 && b % a == 0)
            {
                mr.material = Good;
            }

            if (a / b == 2 && a % b == 0)
            {
                mr.material = Bad;
            }
        }
        for (int i = 0; i < Blocks.Count; i++)
        {
            if (Blocks[i].tag == "LightBlock")
            {
                b++;
            }

            if (b / a == 2 && b % a == 0)
            {
                mr.material = Good;
            }

            if (a / b == 2 && a % b == 0)
            {
                mr.material = Bad;
            }
        }
    }

    

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "AirBlock") ;
        {
            Blocks.Remove(block);
        }
        if (col.gameObject.tag == "LightBlock") ;
        {
            Blocks.Remove(block);
        }
    }
}

    /*MeshRenderer mr = this.GetComponent<MeshRenderer>();


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
}*/


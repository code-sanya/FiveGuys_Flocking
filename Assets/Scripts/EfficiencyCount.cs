using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class EfficiencyCount : MonoBehaviour
{
    private GameObject block;

    public Material Good;
    public Material Bad;
    public float Score = 1f;    

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

   /* private void OnCollisionEnter(Collision col)
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
    }*/

    private void CompareProportion()
    {
        MeshRenderer mr = this.GetComponent<MeshRenderer>();
        int a = 0;
        int b = 0;

        for (int i = 0; i < Blocks.Count; i++)
        {
            if (Blocks[i].tag == "AirBlocks")
            {
                a++;
            }
        }
        for (int i = 0; i < Blocks.Count; i++)
        {
            if (Blocks[i].tag == "LightBlocks")
            {
                b++;
            }

            if (b / a == 2 && b%a == 0 )
            {
                mr.material = Good;
            }

            if (a / b  == 2 && a % b == 0)
            {
                mr.material = Bad;
            }
        }
    }
}

    
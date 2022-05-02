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
    private List<GameObject> Airblocks = new List<GameObject>();
    private List<GameObject> Lightblocks = new List<GameObject>();
    private List<GameObject> OpenSpaceblocks = new List<GameObject>();
    private List<GameObject> IndoorGreenblocks = new List<GameObject>();


    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            MeshRenderer mr = this.GetComponent<MeshRenderer>();

            List<GameObject> Air = new List<GameObject>();

           /*List<Guest> guests = GuestManager.Instance.GuestList();

            foreach  (AirBlockInstantiator air in _airblocks)
           foreach (Guest guest in guests)
            {
                if (guest.Status == Guest.Action.BATHING)
                {

                    Vector3 Floor = Height.transform.position;
                    if (!In.Contains(guest) && Mathf.Abs(guest.transform.position.y - Floor.y) < 1f)
                    {
                        In.Add(guest);
                    }

                }

                Score = In.Count;*/

                if (Score == 2)
            {
                mr.material = Good;
            }

            else if (Score == 8)
            {
                mr.material = Bad;
            }
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
}

    
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sticky : MonoBehaviour
{
    private float Size = 1;
    // Start is called before the first frame update

    public List<GameObject> stuckys = new List<GameObject>();

    void Start()
    {
        //timer = waiTime;
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Sticky"))
        {
            collision.transform.parent = this.transform;
            //Size += collision.transform.localScale.magnitude;
            stuckys.Add(collision.gameObject);
        }
    }
    private void Update()
    {
        RemoveCubes();
    }
    private void RemoveCubes()
     {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //this.GetComponent<Sticky>().enabled = false;
            foreach(GameObject go in stuckys)
            {
                go.transform.parent = null; //remove child from parent
            }
        }

     }
   
}

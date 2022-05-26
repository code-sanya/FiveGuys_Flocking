using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockInstantiator : MonoBehaviour
{
    public GameObject care;
    public GameObject water;
    public GameObject seed;
    public GameObject soil;
    private List<GameObject> _blocks;
    private float Time = 10f;

    // Start is called before the first frame update
    void Start()
    {
        _blocks = new List<GameObject>();        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("North"))
        {
            //Debug.Log("Mouse Click");
            GameObject block = Instantiate(care, this.transform.position, Quaternion.identity);
            _blocks.Add(block);
            Destroy(block, Time);
            //Instantiate(Prefab,this.transform.position, Quaternion.identity);
        }

        if (Input.GetButtonDown("South"))
        {
            //Debug.Log("Mouse Click");
            GameObject block = Instantiate(water, this.transform.position, Quaternion.identity);
            _blocks.Add(block);
            Destroy(block, Time);
            //Instantiate(Prefab,this.transform.position, Quaternion.identity);
        }

        if (Input.GetButtonDown("East"))
        {
            //Debug.Log("Mouse Click");
            GameObject block = Instantiate(seed, this.transform.position, Quaternion.identity);
            _blocks.Add(block);
            Destroy(block, Time);
            //Instantiate(Prefab,this.transform.position, Quaternion.identity);
        }

        if (Input.GetButtonDown("West"))
        {
            //Debug.Log("Mouse Click");
            GameObject block = Instantiate(soil, this.transform.position, Quaternion.identity);
            _blocks.Add(block);
            Destroy(block, Time);
            //Instantiate(Prefab,this.transform.position, Quaternion.identity);
        }

    }
}

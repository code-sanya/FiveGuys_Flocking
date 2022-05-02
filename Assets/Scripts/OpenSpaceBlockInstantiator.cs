using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenSpaceBlockInstantiator : MonoBehaviour

{
    public GameObject Prefab;
    private List<GameObject> _openspaceblocks;

    // Start is called before the first frame update
    void Start()
    {
        _openspaceblocks = new List<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Debug.Log("Mouse Click");
            GameObject block = Instantiate(Prefab, this.transform.position, Quaternion.identity);
            _openspaceblocks.Add(block);
            //Instantiate(Prefab,this.transform.position, Quaternion.identity);

        }


    }
}
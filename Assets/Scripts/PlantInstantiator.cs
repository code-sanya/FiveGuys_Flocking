using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlantInstantiator : MonoBehaviour
{
    public GameObject Plant1;
    public GameObject Plant2;
    public GameObject Plant3;
    public GameObject Plant4;
    public GameObject Plant5;
    public GameObject Plant6;
    public GameObject Plant7;
    public GameObject Plant8;
    public GameObject Plant9;
    public GameObject Plant10;
    private List<GameObject> _plants;
    //Im refers to Image change script
    public ImageChange Imscript;
    public int matchnum;
    public BlockInstantiator BIscript;
    //BI refers to block instantiator script
    public int careCount;
    public int waterCount;
    public int seedCount;
    public int soilCount;

    // Start is called before the first frame update
    private void Start()
    {
        insPlant();

    }

    // Update is called once per frame
    private void Update()
    {
        insPlant();

    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.name.Contains("care"))
        {
            careCount++;
        }
        if (col.name.Contains("Water"))
        {
            waterCount++;
            Debug.Log(waterCount);
        }

        if (col.name.Contains("seed"))
        {
            seedCount++;
        }
        if (col.name.Contains("Soil"))
        {
            soilCount++;
        }
    }

    void insPlant()
    {


        if (careCount == 1 && waterCount == 1 && seedCount == 1 && soilCount == 1)
        {
            GameObject pblock = Instantiate(Plant3, this.transform.position, Quaternion.identity);
            
        }

        else if (careCount == 1 && waterCount == 1 && seedCount == 2 && soilCount == 2)
        {
            GameObject pblock = Instantiate(Plant9, this.transform.position, Quaternion.identity);
           
        }
    }

    /*void backup()
    {
        if (Input.GetMouseButtonDown(0))
        {
            matchnum = Imscript.num;
            Instantiate(prefab[matchnum], this.transform.position, Quaternion.identity);
        }
    }*/

}



using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Dialogue : MonoBehaviour
{
    public GameObject Balloon;
    public string Text;

    public AudioSource audio1;
    public AudioClip[] clips;
 
    public GameObject []Appear;


    private GameObject _curBalloon;

    public GameObject water;
    public GameObject care;
    public GameObject soil;
    public GameObject seed;



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


    private void OnTriggerEnter(Collider col)
    {
        if (col.name.Contains("care"))
        {
            careCount++;
            insPlant();
        }
        if (col.name.Contains("Water"))
        {
            waterCount++;
            insPlant();
        }

        if (col.name.Contains("seed"))
        {
            seedCount++;
            insPlant();
        }
        if (col.name.Contains("Soil"))
        {
            soilCount++;
            insPlant();
        }
        /*if (col.name.Contains("Water"))
        {
            waterCount++;
        }

        if (col.name.Contains("seed"))
        {
            seedCount++;
        }

        if (gameobject.name == "water")
        {
            waterCount -= 1;
            seedCount -= 1;
            ////instantiate
            //return;
        }*/
        //if (col.tag != "Sticky") { return; }
        Canvas canvas = FindObjectOfType<Canvas>();
        if (canvas == null) { return; }

       _curBalloon = Instantiate(Balloon); //create text balloon
       _curBalloon.GetComponent<RectTransform>().position = new Vector2(Screen.width / 2.0f, 15); //position text balloon
        _curBalloon.GetComponent<Text>().text = Text; //update text in balloon
        _curBalloon.transform.parent = canvas.transform; //add balloon under Canvas

        //font size
        int screenHeight = Screen.height;
        float fontSize = screenHeight / 10.0f; Debug.Log((int)fontSize);
        _curBalloon.GetComponent<Text>().fontSize = (int)fontSize; //update text in balloon
        Vector2 rectSize = _curBalloon.GetComponent<RectTransform>().sizeDelta;
        rectSize.y = (int)(fontSize / 0.825);
        _curBalloon.GetComponent<RectTransform>().sizeDelta = rectSize;
       

        //object show
        foreach(GameObject obj in Appear)
            if (obj != null)
        { obj.SetActive(true); }
        

        

        //audio
        if (audio1 == null) { return; }
        if (clips.Length == 0) { return; }
        int i = Random.Range(0, clips.Length); //random number within clips length
        audio1.clip = clips[c];
        audio1.Play();
        c++;
        if (c >= clips.Length) { c = 0; }

        /*//option 1
        //dictionary setup
        Dictionary<string, GameObject> plantTypes = new Dictionary<string, GameObject>();
        plantTypes.Add("1_1", null);
        plantTypes.Add("2_1", null);

        string type = waterCount + "_" + seedCount;
        if (plantTypes.ContainsKey(type))
        {
            GameObject prefab = plantTypes[type];
            string[] parts = type.Split('_');
            waterCount -= int.Parse(parts[0]);
            seedCount -= int.Parse(parts[1]);
        }*/

        /*//option 2
        if (waterCount == 1 && seedCount == 1)
        {
            waterCount -= 1;
            seedCount -= 1;
            //instantiate
            return;
        }
        if (waterCount == 2 && seedCount == 1)
        {
            waterCount -= 2;
            seedCount -= 1;
            //instantiate
            return;
        }*/

    }
    private void insPlant()
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

    private int c = 0;

    private void OnTriggerExit(Collider col)
    {
        if (col.tag != "Player") { return; }
        if (_curBalloon == null) { return; }
       // if (Appear != null) { Appear.SetActive(false); }
        Destroy(_curBalloon);
    }
}
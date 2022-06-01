using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public Sprite[] images;
    public Image icon;
    public int num;
    private float MinTime = 0f;
    private float MaxTime = 5f;   
    
        
    // Start is called before the first frame update
    /*void Start()
    {
        //changeimage();
    }*/

    // Update is called once per frame
    void Update()
    {
        changeimage();
        
    }

    void changeimage()
    {
        int randomNumber = Random.Range(0, 10);        

        /*if (Input.GetKey(KeyCode.Space))
        {
          
            icon.sprite = images[randomNumber];
            num = randomNumber;            
        }*/

        MinTime += Time.deltaTime;
        if (MinTime >= MaxTime)
        {
            foreach (Sprite image in images)
            {
                icon.sprite = images[randomNumber];
                num = randomNumber;
            }
        }

    }
}

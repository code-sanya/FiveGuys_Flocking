using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ImageChange : MonoBehaviour
{
    public Sprite[] images;
    public Image icon;
    public int num;
    private float Time = 2f;
    
        
    // Start is called before the first frame update
    void Start()
    {
        changeimage();
    }

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

        /*if(Time)
        {

            icon.sprite = images[randomNumber];
            num = randomNumber;
        }*/


    }
}

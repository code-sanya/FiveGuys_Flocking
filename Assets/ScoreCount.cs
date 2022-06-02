using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreCount : MonoBehaviour
{
    public int Score;
    public Text ScorePoints;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score = GameObject.FindGameObjectsWithTag("ScoreCount").Length;
        ScorePoints.text = Score.ToString();
        Debug.Log(Score);
    }
}

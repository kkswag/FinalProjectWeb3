using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class scorecoin_script : MonoBehaviour
{
    // Start is called before the first frame update
    public static int c_score;
    public Text myText;
    void Start()
    {
        c_score = 0;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myText.text = ": " + c_score;
    }

    static public void AddScore()
    {
        c_score++;
    }
}

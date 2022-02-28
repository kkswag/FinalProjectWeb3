using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class total_script : MonoBehaviour
{
    // Start is called before the first frame update
    public Text totalCoin;
    public static int c;
    void Start()
    {
        c = (scorecoin_script.c_score);
        totalCoin.text = " " + c;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

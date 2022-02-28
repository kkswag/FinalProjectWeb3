using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timeCount_script : MonoBehaviour
{
    // Start is called before the first frame update
    public float timeCount = 10;
    public Text boxCount;
    public int timeCountInt = 0;
    
    void Start()
    {
        boxCount.text = timeCount.ToString();
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        timeCount -= Time.deltaTime;
        boxCount.text = Mathf.Round(timeCount).ToString();
        timeCountInt = (int)timeCount;
        
        //print(timeCountInt);
        if (timeCountInt == 0)
        {
            SceneManager.LoadScene("end");
        }

        


    }

    

}

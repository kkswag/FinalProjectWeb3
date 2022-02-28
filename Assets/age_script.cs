using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class age_script : MonoBehaviour
{
    public static int max;
    public static int min;
    public static string sex;
    // Start is called before the first frame update
    void Start()
    {
        max = 12;
        min = 4;
        sex = "Male";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void ageCal(int age = 0)
    {
        if (age == 0) //male
        {
            max = 12;
            min = 4;
            print("male");
            sex = "Male";
        }
        if (age == 1)
        {
            max = 10;
            min = 6;
            print("female");
            sex = "Female";
        }

    }
}

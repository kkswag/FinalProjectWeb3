using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Agent_Script : MonoBehaviour
{
    public GameObject coin;
    public int count = 0;
    public bool tf = true;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("coinmove", 1.87f, 0.8f);
    }

    void coinmove()
    {
        if (tf)
        {
            if(count == 2)
            {
                tf = false;
            }
            else
            {
                Vector3 p = new Vector3(9f, 3f, 0);
                Instantiate(coin, p, transform.rotation);
                count++;
            }
            
        }else
        if (tf == false)
        {
            if (count == 0)
            {
                tf = true;
            }
            else
            {
                Vector3 p = new Vector3(9f, -1f, 0);
                Instantiate(coin, p, transform.rotation);
                count--;
            }
            
        }

    }

    // Update is called once per frame
    void Update()
    {
       
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bg_script : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.Translate(-0.05f, 0, 0);
        if (transform.position.x <= -229.4f)
            transform.position = new Vector3(11.96f, 0, 0);
    }
}

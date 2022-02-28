using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin_script : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //speed = Random.Range(-0.05f, -0.1f);
        speed = -0.05f;
        transform.position += new Vector3(speed, 0, 0);
        if (transform.position.x < -10)
            Destroy(this.gameObject); // Destroy(gameObject)
    }
}

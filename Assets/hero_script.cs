using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hero_script : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject hero;
    public int value;
    public Animator animator;
    void Start()
    {
        value = 8;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        value = Arduino_Initial.value;
        print(Arduino_Initial.value);
        if (value <= age_script.min && transform.position.y <=3)
        {
            transform.position += Vector3.up * 0.09f;
            animator.SetInteger("value", value);
        }
        else

        if (value >= age_script.max && transform.position.y >=-1)
        {
            transform.position += Vector3.down * 0.09f;
            animator.SetInteger("value", value);
        }


    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "coin")
        {
            Destroy(collision.gameObject); //remove 2nd object
            scorecoin_script.AddScore();
        }
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // Start is called before the first frame update
    public static PlayerController playerController;

    public float speed;
    float speedR;

    void Start()
    {
        playerController = this;
        speedR = speed * -1;
    }

    // Update is called once per frame
    //Controlador personaje vision aerea
    
    void Update()
    {
        if (!gameObject.GetComponent<Animator>().GetBool("muerte"))
        {
            if (Input.GetKey("left"))
            {
                gameObject.transform.Translate(speedR * Time.deltaTime, 0, 0);
                gameObject.GetComponent<Animator>().SetBool("moving", true);
                gameObject.GetComponent<SpriteRenderer>().flipX = false;
            }
            if (Input.GetKey("right"))
            {
                gameObject.transform.Translate(speed * Time.deltaTime, 0, 0);
                gameObject.GetComponent<Animator>().SetBool("moving", true);
                gameObject.GetComponent<SpriteRenderer>().flipX = true;
            }
            if (Input.GetKey("up"))
            {
                gameObject.transform.Translate(0, speed * Time.deltaTime, 0);
                gameObject.GetComponent<Animator>().SetBool("moving", true);
            }
            if (Input.GetKey("down"))
            {
                gameObject.transform.Translate(0, speedR * Time.deltaTime, 0);
                gameObject.GetComponent<Animator>().SetBool("moving", true);
            }

            if (!Input.GetKey("left") && !Input.GetKey("right") && !Input.GetKey("up") && !Input.GetKey("down"))
            {
                gameObject.GetComponent<Animator>().SetBool("moving", false);
            }
        }
    }

    public void Dead()
    {
        gameObject.GetComponent<Animator>().SetBool("muerte", true);
        Debug.Log("You died");
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody playerRb;
    private float speed = 20f;
    private int temp;
    // Start is called before the first frame update
    void Start()
    {
        playerRb = GetComponent<Rigidbody>();
       
    }

    // Update is called once per frame
    void FixedUpdate()
    { //moving player
        if (Input.GetKey(KeyCode.UpArrow))
        {
            this.transform.Translate(Vector3.forward * Time.deltaTime);
            playerRb.AddForce(transform.forward * speed * Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            this.transform.Translate(Vector3.back * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            this.transform.Translate(Vector3.left*Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            this.transform.Translate(Vector3.right*Time.deltaTime);
            
        }

    }
     // if player collides with enemy increase its size gradually
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            transform.localScale += new Vector3(2f, 2f, 2f)*Time.deltaTime;
            temp++;
            temp = temp + 1;
            Debug.Log("Score of Player"+ temp);//adding score to console
        }
        
    }
}







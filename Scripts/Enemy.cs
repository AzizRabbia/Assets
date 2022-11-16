using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private float speed = 0.5f;
    private Rigidbody enemyRb;
    private GameObject player;
    // Start is called before the first frame update
    void Start()
    {
        enemyRb = GetComponent<Rigidbody>();
        player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        // applying force in the direction of player
        enemyRb.AddForce((player.transform.position - transform.position) * speed);

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == ("Player")) 
        {
            Destroy(this.gameObject); //destroy the enemy when player collides with it
        }
        
    }
}

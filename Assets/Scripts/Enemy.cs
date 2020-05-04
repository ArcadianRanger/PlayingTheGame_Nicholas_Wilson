using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    private Rigidbody enemyRB;
    private GameObject player;
    public float speed;
    private int outOfBounds = -10;
    // Start is called before the first frame update
    void Start()
    {
       enemyRB = GetComponent<Rigidbody>();
       player = GameObject.Find("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y < outOfBounds)
        {
            Destroy(gameObject);
        }

        Vector3 moveDir = (player.transform.position - transform.position).normalized;
        enemyRB.AddForce(moveDir * speed);
    }
}

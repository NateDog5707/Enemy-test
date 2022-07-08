using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileStraight : MonoBehaviour
{
    [SerializeField] private Transform playerTarget;
    private Rigidbody2D rb;
    private Vector2 moveFireball;
    [SerializeField] private float speed = 1f;

    // takes into account the direction/angle from initial casting point to player location
    void Start()
    {
        //for moving this object
        rb = this.GetComponent<Rigidbody2D>();
        //gets direction, "aiming"
        Vector2 directionFireball = playerTarget.position - transform.position;
        Debug.Log(directionFireball);

        //im not sure what this does, i just copied code
        directionFireball.Normalize();
        moveFireball = directionFireball;

        //calls to move fireball
        moveFireballStraight(moveFireball);
    }



    void moveFireballStraight(Vector2 direction)
    {
        rb.velocity = new Vector2(direction.x * speed, direction.y * speed);

    }
}

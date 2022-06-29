using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyChasePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector2 movement;
    [SerializeField] private float speed = 3f;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();


    }

    void Update(){
        direction = GetComponent<EnemyFacePlayer>().getDirection();
        direction.Normalize();
        movement = direction;
    }


    private void FixedUpdate(){
        //calls character movement function
        moveCharacter(movement);
    }

    //moves character position 
    void moveCharacter (Vector2 direction){
        rb.MovePosition((Vector2)transform.position + (direction * speed *Time.deltaTime));
    }
}

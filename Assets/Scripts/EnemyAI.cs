using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform playerTarget;
    private bool flipped = false;
    private Vector2 movement;
    [SerializeField] private float speed = 3f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 direction = playerTarget.position - transform.position;
                Debug.Log(direction);
        float angle = Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg;
            //Takes the angle from enemy position to player position
        //rb.rotation = angle+180;

        if (angle > -90 && angle < 90 && !flipped)
        {
            transform.localScale = new Vector3 (-1 * transform.localScale.x, transform.localScale.y ,transform.localScale.z);
            flipped = true;
        }
        if ((angle < -90 || angle > 90) && flipped)
        {
            transform.localScale = new Vector3 (-1 * transform.localScale.x, transform.localScale.y ,transform.localScale.z);
            flipped = false;
        }
            //Debug.Log(angle);
            //Flips enemy sprite from side to side to face player

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

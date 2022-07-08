using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleMovement : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 roamPosition;
    private Vector3 direction;
    [SerializeField] private float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        roamPosition = GetRoamingPosition();
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, roamPosition) < 1f){
            //Reached roamPosition
            roamPosition = GetRoamingPosition();
        }

        // move character towards the randomized position
        Vector3 temp = (direction * speed * Time.deltaTime);

        Debug.Log($"Vector: {temp.ToString()} \tFrame: {Time.deltaTime} ");

        rb.MovePosition(transform.position + temp);

    }
    

    private Vector3 GetRoamingPosition()
    {
        Vector3 startingPosition = transform.position;
        //finds new roam destination
        startingPosition.x =+ UnityEngine.Random.Range(-3f, 3f);
        startingPosition.y =+ UnityEngine.Random.Range(-3f, 3f);
        
        //direction from current pos to new roam destination
        direction = startingPosition - transform.position;
        direction.Normalize();
        
        
        return startingPosition;
    }

}

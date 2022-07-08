/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyIdleMove : MonoBehaviour
{
    private Rigidbody2D rb;
    private Vector3 startingPosition;
    private Vector3 roamPosition;
    private Vector3 direction;
    [SerializeField] private float speed = 2f;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
        startingPosition = transform.Position;
        roamPosition = GetRoamingPosition();
    }

    // Update is called once per frame
    void Update()
    {
        
        // move character towards the randomized position
        rb.MovePosition((Vector2)transform.position + (direction * speed * Time.deltaTime));

        if (Vector3.Distance(transform.position, roamPosition) < 1f){
            //Reached roamPosition
            roamPosition = GetRoamingPosition();
        }


    }

    private Vector3 GetRoamingDirection()
    {
        return startingPosition + new Vector3(UnityEngine.Random.Range(-1f, 1f), UnityEngine.Random.Range(-1f, 1f)).normalized * Random.Range(10f, 10f);
        direction = startingPosition.position - transform.position;
    }


}
*/
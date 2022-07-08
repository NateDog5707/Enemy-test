using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFacePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    [SerializeField] private Transform playerTarget;
    private bool flipped = false;
    private Vector3 direction;

    // Start is called before the first frame update
    void Start()
    {
        rb = this.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {   
        //updates direction var
        direction = playerTarget.position - transform.position;
            //Debug.Log(direction);
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
            //Flips enemy sprite from side to side to face player by scaling x by -1

    }

    public Vector3 getDirection()
    {
        return direction;
    }

}

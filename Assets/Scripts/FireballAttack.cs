using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{
    [SerializeField] private Transform playerTarget;
    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject fireballPrefab;
    [SerializeField] private float speed = 1f;
    [SerializeField] private float fireballLifetime = 5f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(shooting());

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator shooting(){
        while(true)
        {
            Shoot();
            yield return new WaitForSeconds(2);
        }
    }

    void Shoot()
    {   //creates new game object to fire at Player
        GameObject clone = Instantiate
        (fireballPrefab, firePoint.position, firePoint.rotation);
        // get direction
        rb = clone.GetComponent<Rigidbody2D>();
        Vector2 directionFireball = playerTarget.position - clone.transform.position;
        directionFireball.Normalize();

        //change velocity
        rb.velocity = new Vector2(directionFireball.x * speed, directionFireball.y * speed);
        
        Destroy (clone, fireballLifetime);
    }

}

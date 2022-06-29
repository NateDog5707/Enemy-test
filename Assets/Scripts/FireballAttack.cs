using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireballAttack : MonoBehaviour
{

    [SerializeField] private Transform firePoint;
    [SerializeField] private GameObject fireballPrefab;

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
        Instantiate(fireballPrefab, firePoint.position, firePoint.rotation);
        
    }

}

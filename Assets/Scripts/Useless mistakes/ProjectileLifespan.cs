using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileLifespan : MonoBehaviour
{

    [SerializeField] private GameObject projectile;
    [SerializeField] private float timer;

    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.gameObject, timer);
        //StartCoroutine(timerExpire());
        //this.GetComponent ?
    }

    // Update is called once per frame
    void Update()
    {
        
    }
/*
    IEnumerator timerExpire()
    {
        yield return new WaitForSeconds(timer);
        Destroy(projectile, timer);

    }
    */
}


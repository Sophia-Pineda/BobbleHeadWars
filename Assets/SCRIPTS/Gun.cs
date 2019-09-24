using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public GameObject bulletPrefab;   /* set to sphere/bullet */
    public Transform launchPosition;   /*refers to the marines gun*/

    void fireBullet()
    {
        //1 create bullet based on sphere prefab
        GameObject bullet = Instantiate(bulletPrefab) as GameObject; 
        //2 bullet pos. set to launcher (gun)
        bullet.transform.position = launchPosition.position;
        //3 constant speed of bullet
        bullet.GetComponent<Rigidbody>().velocity =
            transform.parent.forward * 100;

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))   //checking L. mouse input
        {
            if (!IsInvoking("fireBullet"))  /*If bullet is not invoked, call invoke repeating*/
            {
                InvokeRepeating("fireBullet", 0f, 0.1f);  /*params need a name, time to begin, then time to end*/
            }
        }
        if (Input.GetMouseButtonUp(0))
        {
            CancelInvoke("fireBullet");   //release mouse, gun stops
        }
    }
}

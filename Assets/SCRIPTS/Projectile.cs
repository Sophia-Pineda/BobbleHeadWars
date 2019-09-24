using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    private void OnBecameInvisible()
    {
        Destroy(gameObject);   /*bullet destroyed if leaves cameraline of sight*/
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);       /*Bullet destroyed if collides with wall or alien*/
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

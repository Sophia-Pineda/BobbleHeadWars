using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public GameObject followTarget;
    public float moveSpeed;    //assign camera to follow & its speed - public make its adjustable in UNITY editor
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (followTarget != null)
        {
              //function to calculate camera position
            transform.position = Vector3.Lerp(transform.position,       /*Lerp func param - start pos. in 3d, end pos. in 3d, & a point between both pos.*/
                                              followTarget.transform.position,
                                              Time.deltaTime * moveSpeed);
        }
    }
}

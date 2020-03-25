using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Aim : MonoBehaviour
{
    [SerializeField] Transform cubeTrans;
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        //direction = destination - source
        Vector3 directionToAim = cubeTrans.position - transform.position;
        Debug.DrawRay(transform.position, directionToAim, Color.green);

        //access current location = Quartionian Look Rotaion
        //transform.rotation = Quaternion.LookRotation(directionToAim);

        Quaternion targetRotation = Quaternion.LookRotation(directionToAim);

        transform.rotation = Quaternion.Slerp(transform.rotation, targetRotation, Time.deltaTime);


    }
}

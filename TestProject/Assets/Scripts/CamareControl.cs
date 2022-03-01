using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamareControl : MonoBehaviour
{
   
    Vector3 Distance;
    GameObject Target;


    private void Start()
    {
        Target = GameObject.FindGameObjectWithTag("Player");
        Distance = transform.position - Target.transform.position;
    }

    void Update()
    {

        transform.position = Target.transform.position + Distance;

    }
}

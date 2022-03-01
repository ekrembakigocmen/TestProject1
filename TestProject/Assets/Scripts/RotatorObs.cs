using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotatorObs : MonoBehaviour
{

    
 


    private void FixedUpdate()
    {

       transform.Rotate(new Vector3(0, -80 * Time.deltaTime, 0));
       

    }
}

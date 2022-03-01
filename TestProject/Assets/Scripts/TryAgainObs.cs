using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TryAgainObs : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        Transform transform = collision.transform.GetComponent<Transform>();

        if (transform != null)
        {

            collision.transform.position = new Vector3(-40, 0, 0);

        }
    }
}

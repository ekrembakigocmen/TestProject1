using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowGround : MonoBehaviour
{
    float Slower = 2f;

    private void OnCollisionStay(Collision collision)
    {
        Rigidbody Rb = collision.collider.GetComponent<Rigidbody>();

        if (Rb != null)
        {
            Vector3 Slider = Rb.velocity;
            Slider.x = -Slower;
            Rb.velocity = Slider;


        }


    }
}

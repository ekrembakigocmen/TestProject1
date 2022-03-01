using UnityEngine;

public class FastGround : MonoBehaviour
{
    float Accelerator = 4.5f;

    private void OnCollisionStay(Collision collision)
    {
        Rigidbody Rb = collision.collider.GetComponent<Rigidbody>();

        if (Rb != null)
        {
            Vector3 Slider = Rb.velocity;
            Slider.x = Accelerator;
            Rb.velocity = Slider;


        }


    }
}

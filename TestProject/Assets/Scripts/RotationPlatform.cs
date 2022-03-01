using UnityEngine;

public class RotationPlatform : MonoBehaviour
{

    float SliderValue= 4.5f;

    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 45 * Time.deltaTime));
    }

    

    private void OnCollisionStay(Collision collision)
    {
        Rigidbody Rb = collision.collider.GetComponent<Rigidbody>();

        if (Rb != null)
        {
            Vector3 Slider = Rb.velocity;
            Slider.z = SliderValue;
            Rb.velocity = Slider;



        }
    }
}

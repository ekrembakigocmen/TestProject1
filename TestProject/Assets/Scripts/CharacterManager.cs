using UnityEngine;

public class CharacterManager : MonoBehaviour
{

    Animator animator;

    Vector3 pos;
    float inputX;
    float inputZ;
    //public Transform Boy;
   
   public float Speed;
    float Left_Move;
    float Back_Move;
    float Right_Move;
    void Start()
    {
        animator = GetComponent<Animator>();
      //  Boy = GetComponent<Transform>();


    }



    void FixedUpdate()
    {
        
        if (transform.position.y <= -7)
        {

            this.gameObject.transform.position = new Vector3(-40, 0, 0);

        }



        if (Input.GetKey(KeyCode.W))
        {
            Speed = 1f;


            inputX = Speed * Input.GetAxis("Horizontal");
            inputZ = Speed * Input.GetAxis("Vertical");

        }
        else
        {
            Speed = 0f;
            inputX = Speed * Input.GetAxis("Horizontal");
            inputZ = Speed * Input.GetAxis("Vertical");

        }

        if (Input.GetKey(KeyCode.S))
        {
            Back_Move = 1f;
            inputX = 0.5f * Input.GetAxis("Horizontal");
            inputZ = 0.5f * Input.GetAxis("Vertical");

        }
        else
        {
            Back_Move = 0f;
            inputX = 0.5f * Input.GetAxis("Horizontal");
            inputZ = 0.5f * Input.GetAxis("Vertical");

        }

        if (Input.GetKey(KeyCode.A))
        {
            if (Input.GetKey(KeyCode.W))
            {

                animator.SetFloat("Left_Move", Left_Move = .5f);
                inputX = 1f * Input.GetAxis("Horizontal");
                inputZ = 1f * Input.GetAxis("Vertical");

            }

            else
            {

                animator.SetFloat("Left_Move", Left_Move = .03f);
                inputX = 0.5f * Input.GetAxis("Horizontal");
                inputZ = 0.5f * Input.GetAxis("Vertical");

            }

        }
        else
        {

            animator.SetFloat("Left_Move", Left_Move = 0f);
            inputX = 0.5f * Input.GetAxis("Horizontal");
            inputZ = 0.5f * Input.GetAxis("Vertical");

        }

        if (Input.GetKey(KeyCode.D))
        {
            if (Input.GetKey(KeyCode.W))
            {

                animator.SetFloat("Right_Move", Right_Move = .5f);
                inputX = .5f * Input.GetAxis("Horizontal");
                inputZ = .5f * Input.GetAxis("Vertical");

            }

            else
            {

                animator.SetFloat("Right_Move", Right_Move = .03f);
                inputX = 0.5f * Input.GetAxis("Horizontal");
                inputZ = 0.5f * Input.GetAxis("Vertical");

            }

        }
        else
        {

            animator.SetFloat("Right_Move", Right_Move = 0f);
            inputX = 0.5f * Input.GetAxis("Horizontal");
            inputZ = 0.5f * Input.GetAxis("Vertical");

        }




        transform.Translate(new Vector3(inputX, 0f, inputZ) * Time.deltaTime * 10);

        InputMove(Speed);
       
    }


    public void InputMove(float Speed)
    {
        animator.SetFloat("Run", Speed);
        animator.SetFloat("Back_Move", Back_Move);
        animator.SetFloat("Left_Move", Left_Move);
        animator.SetFloat("Right_Move", Right_Move);

    }


    
}

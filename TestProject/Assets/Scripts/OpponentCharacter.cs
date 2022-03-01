using UnityEngine;
using UnityEngine.AI;

public class OpponentCharacter : MonoBehaviour
{
    
    NavMeshAgent Girls;
     GameObject Target;
    

    void Start()
    {
        Girls = GetComponent<NavMeshAgent>();
        Target = GetComponent<GameObject>();
    }

    
    void Update()
    {

        Target = GameObject.FindGameObjectWithTag("target");
        Girls.SetDestination(Target.transform.position);
        if (transform.position.x >= 60 )
        {
            Girls.enabled = false;
            this.gameObject.SetActive(false);
        }

        if (transform.position.y <= -7)
        {

            this.gameObject.transform.position = new Vector3(-40, 0, 0);

        }
    }
}

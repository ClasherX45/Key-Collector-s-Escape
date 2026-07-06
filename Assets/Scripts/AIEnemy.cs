using UnityEngine;
using UnityEngine.AI;

public class AIEnemy : MonoBehaviour
{

    public GameObject thePlayer;

    public float followingDistance = 0;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float currentDist = Vector3.Distance(transform.position, thePlayer.transform.position);

        if (currentDist < followingDistance)
        {
            GetComponent<NavMeshAgent>().destination = thePlayer.transform.position;
        }
        else
        {
            GetComponent<NavMeshAgent>().destination = transform.position;
        }
    }
}

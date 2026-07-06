using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    public PlayerCollectible player;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (player.keyCollected == true)
            {
                door.GetComponent<Animator>().SetBool("DoorOpen", true);
                player.keyCollected = false;
            }
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            //door.GetComponent<Animator>().SetBool("DoorOpen", false);
        }
    }
}

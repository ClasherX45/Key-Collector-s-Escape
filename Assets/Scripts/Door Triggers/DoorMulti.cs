using UnityEditor;
using UnityEngine;
using UnityEngine.ProBuilder.Shapes;

public class DoorMulti : MonoBehaviour
{
    public GameObject door;
    public PlayerCollectible player;

    public int keysNeeded = 0;

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            if (player.keysCollected >= keysNeeded)
            {
                door.GetComponent<Animator>().SetBool("DoorOpen", true);
                player.keysCollected = player.keysCollected - this.keysNeeded;
            }
        }
    }
}

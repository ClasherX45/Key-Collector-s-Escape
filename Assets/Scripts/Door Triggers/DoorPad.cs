using UnityEngine;

public class DoorPad : MonoBehaviour
{
    public GameObject door;

    public DoorPadSwitch doorSwitch;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if(doorSwitch.switchIsOn)
        {
            //doorSwitch is true so door should be open
            door.GetComponent<Animator>().SetBool("DoorOpen", true);
        }

    }




}

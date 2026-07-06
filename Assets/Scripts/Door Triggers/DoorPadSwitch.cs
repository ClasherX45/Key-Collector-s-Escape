using UnityEngine;

public class DoorPadSwitch : MonoBehaviour
{

    public bool switchIsOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //so swithIsOn will be true whenever anything
    //is on the pad
    private void OnTriggerStay(Collider other)
    {
        switchIsOn = true;
    }

    //turn switchIsOn to false if something leaves
    //the pad
    private void OnTriggerExit(Collider other)
    {
        switchIsOn = false;
    }

}

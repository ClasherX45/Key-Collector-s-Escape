using UnityEngine;

public class KeySwitch : MonoBehaviour
{
    public GameObject SideKey;

    public bool switchIsOn = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (switchIsOn == true)
        {
            SideKey.GetComponent<MeshRenderer>().enabled = true;
            SideKey.GetComponent<SphereCollider>().enabled = true;
        }
    }

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

using TMPro;
using UnityEngine;

public class JumpHigher : MonoBehaviour
{
    public float newJumpSpeed = 30f;
    public float duration = 10f;
    public GameObject player;
    private float previousJumpSpeed;
    public GameObject powerUpUI;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        powerUpUI = GameObject.FindWithTag("PowerUPCanvas");
        powerUpUI.GetComponent<TextMeshProUGUI>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Keeps a record of the original jump speed
            previousJumpSpeed = player.GetComponent<PlayerKeyboardMovement>().jumpSpeed;

            //Changes jump speed to power up jump speed
            player.GetComponent<PlayerKeyboardMovement>().jumpSpeed = newJumpSpeed;

            powerUpUI.GetComponent<TextMeshProUGUI>().enabled = true;
            powerUpUI.GetComponent<TextMeshProUGUI>().text = "Jump Activated";

            Deactivate();

            Invoke("ResetJumpSpeed", duration);
        }
    }

    private void ResetJumpSpeed()
    {
        player.GetComponent<PlayerKeyboardMovement>().jumpSpeed = previousJumpSpeed;
        powerUpUI.GetComponent<TextMeshProUGUI>().enabled = false;
    }

    void Deactivate()
    { 
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }
}

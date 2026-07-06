using TMPro;
using UnityEngine;

public class SpeedUp : MonoBehaviour
{
    public float newSpeed = 30f;
    public float duration = 10f;
    private float previousSpeed;

    public GameObject player;
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
            //Keeps a record of the original speed
            previousSpeed = player.GetComponent<PlayerKeyboardMovement>().speed;

            //Changes speed to power up speed
            player.GetComponent<PlayerKeyboardMovement>().speed = newSpeed;

            powerUpUI.GetComponent<TextMeshProUGUI>().enabled = true;
            powerUpUI.GetComponent<TextMeshProUGUI>().text = "Speed Activated";

            Deactivate();

            Invoke("ResetSpeed", duration);
        }
    }

    private void ResetSpeed()
    {
        player.GetComponent<PlayerKeyboardMovement>().speed = previousSpeed;
        powerUpUI.GetComponent<TextMeshProUGUI>().enabled = false;
    }

    void Deactivate()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }
}

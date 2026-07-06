using TMPro;
using UnityEngine;

public class Invincibility : MonoBehaviour
{
    public int newHealth = 150;
    public float duration = 10f;
    private int previousHealth;

    public GameObject player;
    public GameObject powerUpCanvas;

    


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

        player = GameObject.FindWithTag("Player");
        powerUpCanvas = GameObject.FindWithTag("PowerUPCanvas");
        powerUpCanvas.GetComponent<TextMeshProUGUI>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //Keeps a record of the original health
            previousHealth = player.GetComponent<PlayerTrap>().playerHealth;

            //Changes health to power up health
            player.GetComponent<PlayerTrap>().playerHealth = newHealth;

            powerUpCanvas.GetComponent<TextMeshProUGUI>().enabled = true;
            powerUpCanvas.GetComponent<TextMeshProUGUI>().text = "Invincibility Activated";

            Deactivate();

            Invoke("Reset", duration);
        }
    }

    private void Reset()
    {
        player.GetComponent<PlayerTrap>().playerHealth = previousHealth;
        powerUpCanvas.GetComponent<TextMeshProUGUI>().enabled = false;
    }

    void Deactivate()
    {
        GetComponent<MeshRenderer>().enabled = false;
        GetComponent<BoxCollider>().enabled = false;
    }
}

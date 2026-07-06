using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class ProjectilePowerup : MonoBehaviour
{
    public GameObject player;
    public float duration = 2f;

    public GameObject textCanvas;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            player.GetComponent<PlayerProjectile>().activate = true;

            GetComponent<Renderer>().enabled = false;
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<BoxCollider>().enabled = false;

            Invoke("Reset", duration);
        }
    }

    private void Reset()
    {
        textCanvas.GetComponent<TextMeshProUGUI>().enabled = false;
    }
    void Deactivate()
    {
        
    }
}

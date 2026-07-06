using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EscapeBoat : MonoBehaviour
{
    public PlayerCollectible player;
    public GameObject textCanvas;
    public float duration = 3f;

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
            if (player.paddlesCollected == 2)
            {
                SceneManager.LoadScene("Final Project End");
            }
            
        }
    }
}

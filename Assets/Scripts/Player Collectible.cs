using Unity.VisualScripting;
using UnityEngine;
using TMPro;
using System;
using System.Collections;
using UnityEngine.ProBuilder.Shapes;

public class PlayerCollectible : MonoBehaviour
{

    public int keysCollected = 0;
    public bool keyCollected = false;
    public int paddlesCollected = 0;

    public TextMeshProUGUI keyUI;
    public TextMeshProUGUI paddleUI;

    public DoorPadSwitch doorSwitch;
    public GameObject SideKey;


    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        keyUI.text = "Keys: " + keysCollected;
        paddleUI.text = "Paddles: " + paddlesCollected;
        paddleUI.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        keyUI.text = "Keys: " + keysCollected;
        paddleUI.text = "Paddles: " + paddlesCollected;
    }

    //Detects when the player is colliding with an on trigger object. It should not be under update or start.
    private void OnTriggerEnter(Collider collision)
    {

        if (collision.tag == "SideKey")
        {
            keyCollected = true;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Key")
        {
            keysCollected++;
            Destroy(collision.gameObject);
        }

        if (collision.tag == "Paddle")
        {
            paddleUI.enabled = true;
            paddlesCollected++;
            Destroy(collision.gameObject);
        }


    }
    public IEnumerator ExecuteDelayed(Action code)
    {
        yield return new WaitForSeconds(1);
        // Execute delayed code
        code();
    }


}

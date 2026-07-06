using System;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerProjectile : MonoBehaviour
{
    public GameObject projectilePrefab;

    public float forwardVelocity = 10;
    public float upVelocity = 3;
    public int magazine = 8;

    public SoundController soundController;

    public TextMeshProUGUI ammoUI;

    public Boolean activate = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        ammoUI.text = "Ammo: " + magazine;
        ammoUI.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        ammoUI.text = "Ammo: " + magazine;

        if (activate)
        {
            ammoUI.enabled = true;
            //check if we pressed the mouse
            if (Input.GetMouseButtonDown(0))
            {
                if (magazine > 0)
                {
                    soundController.Fire();
                    Vector3 thePosition = transform.TransformPoint(Vector3.forward);
                    //create the projectile in front of the player
                    GameObject createdProjectile = Instantiate(projectilePrefab, thePosition, transform.rotation);

                    //set it's velocity
                    createdProjectile.GetComponent<Rigidbody>().linearVelocity = transform.forward * forwardVelocity + Vector3.up * upVelocity;
                    magazine--;
                } else
                {
                    Invoke("Reset", 4);
                }
            }
        }
    }

    private void Reset()
    {
        magazine = 8;
    }
}
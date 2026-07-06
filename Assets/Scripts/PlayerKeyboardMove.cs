using UnityEngine;

public class PlayerKeyboardMovement : MonoBehaviour
{

    public float speed = 10f;
    public float sprintSpeedAdd = 5f;
    public float jumpSpeed = 5f;
    public float currentJumps = 0f;
    public float maxJumps = 2f;

    //Variable for detecting how far the ground is from the center of player.
    public float groundDist = 1.2f;

    //Add a variable to keep track of whether we are grounded.
    private bool grounded = true;

    //Adds a layer mask for detecting the ground layer.
    public LayerMask groundLayer;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        IsGrounded();

        float currentSpeed;

        if (Input.GetKey(KeyCode.LeftShift) || Input.GetKey(KeyCode.RightShift))
        {
            currentSpeed = speed + sprintSpeedAdd;
        }
        else
        {
            currentSpeed = speed;
        }

        float zspeed = Input.GetAxis("Vertical") * currentSpeed;
        float xspeed = Input.GetAxis("Horizontal") * currentSpeed;

        float yspeed;
        if(Input.GetKeyDown(KeyCode.Space) && currentJumps < maxJumps)
        {
             yspeed = jumpSpeed;
             currentJumps++;
        } else
        {
             yspeed = GetComponent<Rigidbody>().linearVelocity.y;
        }

        if(grounded == true)
        {
            currentJumps = 0;
        }

        Vector3 movement = new Vector3(xspeed, yspeed, zspeed);

        GetComponent<Rigidbody>().linearVelocity = transform.TransformDirection(movement);

    }

    private void IsGrounded()
    {
        //Debug.DrawRay(transform.position, Vector3.down * groundDist, Color.black);
        if (Physics.Raycast(transform.position, Vector3.down, groundDist, groundLayer))
        {
            grounded = true;
            //if i'm grounded, i'm not jumping
            //tell the animator component
            //GetComponent<Animator>().SetBool("isJumping", false);
            //GetComponent<Animator>().SetBool("isFalling", false);
        }
        else
        {
            grounded = false;
            //tell the animator component
            //GetComponent<Animator>().SetBool("isJumping", true);
            //if (GetComponent<Rigidbody2D>().linearVelocityY < 0)
            {
            //    GetComponent<Animator>().SetBool("isJumping", false);
            //    GetComponent<Animator>().SetBool("isFalling", true);
            }
            //else if (GetComponent<Rigidbody2D>().linearVelocityY > 0)
            {
            //    GetComponent<Animator>().SetBool("isFalling", false);
            }
        }
    }



}

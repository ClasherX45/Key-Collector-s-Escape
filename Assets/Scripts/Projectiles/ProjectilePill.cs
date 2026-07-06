using UnityEngine;

public class ProjectilePill : MonoBehaviour
{
    public GameObject soundController;

    public void Start()
    {
        soundController = GameObject.FindWithTag("SoundController");
    }

    //decide what to do when the projectile hits things
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Enemy")
        {
            //hit an enemy
            //Debug.Log("projectile hit enemy");

            soundController.GetComponent<SoundController>().Death();
            //destroy enemy
            Destroy(other.gameObject);

            //destroy this projectile
            Destroy(gameObject);
        }
        else if (other.tag != "Player")
        {
            //hit something else
            //destroy this projectile
            Destroy(gameObject);
        }
    }
}
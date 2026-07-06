using UnityEngine;

public class SoundController : MonoBehaviour
{

    public AudioSource deathSound;
    public AudioSource fireSound;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Death()
    {
        deathSound.Play();
    }

    public void Fire()
    {
        fireSound.Play();
    }
}

using UnityEngine;
using UnityEngine.SceneManagement;

public class StartButton : MonoBehaviour
{
    //
    public void StartScreen()
    {
        //this is how you load a scene.
        //but the text in quotes must match
        //the name of your main game scene.
        //the name of your scene might be
        //"SampleScene" if you didn't change it
        SceneManager.LoadScene("Final Project");
    }
}

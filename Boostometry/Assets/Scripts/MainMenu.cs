using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //This script can just be merged with Game Manager instead
    public string sceneToLoad;
    public static MainMenu Instance;
    public Animator transition;
    public void Play()
    {
        transition.SetTrigger("Start");
        StartCoroutine(waitForTime());
    }

    public void Quit()
    {
        Application.Quit();
    }

    IEnumerator waitForTime()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(sceneToLoad);
    }
}

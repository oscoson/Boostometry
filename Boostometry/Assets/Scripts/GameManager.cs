using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    // We create a static instance of our game manager so we can easily grab it from anywhere in our game
    public static GameManager Instance;
    public GameObject pauseCanvas;
    public Text currentLevelText;
    public Animator transition;
    public bool portalHit;


    void Awake()
    {
        Instance = this;
    }
    
    void Start()
    {
        portalHit = false;
        currentLevelText.text = SceneManager.GetActiveScene().name;
    }

    void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.P) && !(pauseCanvas.activeInHierarchy) && !(portalHit))
        {
            PauseButton();
        }

        else if(Input.GetKey(KeyCode.P) && pauseCanvas.activeInHierarchy)
        {
            Continue();
        }
    }

    public void PauseButton()
    {
        Time.timeScale = 0;
        pauseCanvas.SetActive(true);


    }

    public void Continue()
    {
        Time.timeScale = 1;
        pauseCanvas.SetActive(false);
    }

    public void GoToMenu()
    {
        pauseCanvas.SetActive(false);
        transition.SetTrigger("Start");
        Time.timeScale = 1;
        StartCoroutine(waitTime());
    }

    IEnumerator waitTime()
    {
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene("Main Menu");
    }

    
}

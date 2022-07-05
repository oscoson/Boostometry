using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager Instance;
    public GameObject player;
    public Transform respawnPoint;
    public string sLevelToLoad;
    public Animator transition;
    public AudioSource nextLevelAudio;
    public AudioSource levelComplete;
    private float transitionTime = 1.5f;

    void Awake()
    {
        Instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Respawn()
    {

        player.transform.position = respawnPoint.position;
        player.GetComponent<Rigidbody2D>().velocity = Vector3.zero;
        player.GetComponent<TrailRenderer>().Clear();
    }

    public void LoadLevel()
    {
        StartCoroutine(LevelTransition(sLevelToLoad));
    }


    IEnumerator LevelTransition(string levelName)
    {

        transition.SetTrigger("Start");

        yield return new WaitForSeconds(transitionTime);

        SceneManager.LoadScene(levelName);
    }

}

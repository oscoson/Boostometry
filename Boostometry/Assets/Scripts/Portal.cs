using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Portal : MonoBehaviour
{
    [SerializeField] private float completeTime = 1.5f;
    public GameObject portalEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject playerObject =  collision.gameObject;

        if(playerObject.tag == "Player")
        {
            GameManager.Instance.portalHit = true;
            Destroy(playerObject);
            Instantiate(portalEffect, transform.position, Quaternion.identity);
            StartCoroutine(LevelComplete());
        }
    }

    IEnumerator LevelComplete()
    {
        LevelManager.Instance.levelComplete.Play();
        yield return new WaitForSeconds(completeTime);
        LevelManager.Instance.LoadLevel();
    }
}
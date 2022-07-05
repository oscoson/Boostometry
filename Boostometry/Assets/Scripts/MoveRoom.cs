using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRoom : MonoBehaviour
{
    public string loadsceneName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject playerObject =  collision.gameObject;

        if(playerObject.tag == "Player")
        {
            LevelManager.Instance.sLevelToLoad = loadsceneName;
            Destroy(playerObject);
            LevelManager.Instance.LoadLevel();
        }
    }
}

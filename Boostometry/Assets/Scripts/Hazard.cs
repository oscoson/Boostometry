using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hazard : MonoBehaviour
{

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            LevelManager.Instance.Respawn();
        }

        if(this.tag == "Bullet" && collision.tag != "Cannon Box")
        {
            Destroy(this.gameObject);
        }
    }
}

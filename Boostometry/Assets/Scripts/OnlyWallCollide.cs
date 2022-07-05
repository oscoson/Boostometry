using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnlyWallCollide : MonoBehaviour
{

    public GameObject invisWall;
    public GameObject player;


    void Awake()
    {
        Debug.Log("Ping!");
        Physics2D.IgnoreCollision(invisWall.GetComponent<Collider2D>(), player.GetComponent<Collider2D>());
    }
 


}

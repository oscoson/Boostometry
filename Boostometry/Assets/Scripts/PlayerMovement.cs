using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody2D playerRB;
    public Camera mainCamera;
    public float pushForce;
    public AudioSource wallHit;
    private bool firstSpawn = false;
    Vector2 mousePos;

    // Start is called before the first frame update
    void Start()
    {
        firstSpawn = false;
    }

    // Update is called once per frame
    void Update()
    {
        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);
        
        if(Input.GetButtonDown("Fire1"))
        {
            Boost();
        }   
    }

    void Boost()
    {
        Vector2 lookDir = mousePos - playerRB.position;

        Rigidbody2D rb = playerRB.GetComponent<Rigidbody2D>();

        rb.AddForce(-(lookDir) * pushForce, ForceMode2D.Impulse);

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        GameObject wall =  collision.gameObject;

        if(wall.tag == "Wall" && firstSpawn)
        {
            wallHit.Play();
        }
        else
        {
            firstSpawn = true;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShooting : MonoBehaviour
{
    private float timeBetweenShots = 0.5f;
    public float shootSpeed;
    public GameObject bullet;
    public Transform shootPos;
    public bool canShootDown;
    public bool canShootUp;

    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (canShootDown == true)
        {
            StartCoroutine(ShootDown());
        }
        if(canShootUp == true)
        {
            StartCoroutine(ShootUp());
        }
    }

    IEnumerator ShootDown()
    {
        canShootDown = false;
        yield return new WaitForSeconds(timeBetweenShots);
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        Vector3 direction = -transform.up;
        rb.AddForce(direction * shootSpeed, ForceMode2D.Impulse);
        canShootDown = true;
    }

    IEnumerator ShootUp()
    {
        canShootUp = false;
        yield return new WaitForSeconds(timeBetweenShots);
        GameObject newBullet = Instantiate(bullet, shootPos.position, Quaternion.identity);
        Rigidbody2D rb = newBullet.GetComponent<Rigidbody2D>();
        Vector3 direction = transform.up;
        rb.AddForce(direction * shootSpeed, ForceMode2D.Impulse);
        canShootUp = true;
    }
}

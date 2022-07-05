using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfterXTime : MonoBehaviour
{
    [SerializeField] private float timeLimit;


    void Start()
    {
        StartCoroutine(CountDown());

    }

    IEnumerator CountDown()
    {
        yield return new WaitForSeconds(timeLimit);
        Destroy(this.gameObject);
    }

}

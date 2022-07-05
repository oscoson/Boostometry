using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public LockManager lockManagement;

    private void OnCollisionEnter2D(Collision2D col)
    {
        GameObject playerObject =  col.gameObject;

        if(playerObject.tag == "Player")
        {
            if(this.tag == "MainButton")
            {
                lockManagement.MainButtonPressed();
            }
            if(this.tag == "MiniButton")
            {
                lockManagement.MiniButtonPressed();
            }
            this.gameObject.SetActive(false);
        }
    }
}

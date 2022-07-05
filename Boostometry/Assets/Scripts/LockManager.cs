using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockManager : MonoBehaviour
{
    public static LockManager Instance;
    public int mainButtonAmount;
    public int currentMainButtonAmount;
    public int miniButtonAmount;
    public int currentMiniButtonAmount;
    

    public void MainButtonPressed()
    {
        currentMainButtonAmount += 1;
        if(mainButtonAmount == currentMainButtonAmount)
        {
            Destroy(this.gameObject);
        }
    }

    public void MiniButtonPressed()
    {
        currentMiniButtonAmount += 1;
        if(miniButtonAmount == currentMiniButtonAmount)
        {
            Destroy(this.gameObject);
        }
    }
}

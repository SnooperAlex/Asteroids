using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievmentManager : MonoBehaviour, IAchievment
{
    public void UnlockAchievment(string ID)
    {
        Debug.Log("Achievment " + ID + " unlocked");
    }
}

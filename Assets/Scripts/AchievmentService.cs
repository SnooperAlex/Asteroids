using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AchievmentService : MonoBehaviour
{
    private IAchievment abstractAchievment;

    private void Awake()
    {
        abstractAchievment = GetComponent<IAchievment>();
    }

    public void UnlockAchievment(AchievmentsObject achievment)
    {
        abstractAchievment.UnlockAchievment(achievment);
    }
}

using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

using UnityEngine.UI;

public class AchievmentManager : MonoBehaviour, IAchievment
{
    public TextMeshProUGUI achievmentName;
    public TextMeshProUGUI achievmentDesc;

    public GameObject panel;
    

    public void UnlockAchievment(AchievmentsObject achievment)
    {
        achievmentName.text = achievment.ID;
        achievmentDesc.text = achievment.description;
        achievment.unlocked = true;
        StartCoroutine(AchievmentShow());

    }

    IEnumerator AchievmentShow()
    {
        CanvasGroup group = panel.GetComponent<CanvasGroup>();
        group.alpha = 1;
        yield return new WaitForSeconds(3);
        group.alpha = 0;
       
    }
}

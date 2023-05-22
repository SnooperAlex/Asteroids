using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class AchievmentDisplay : MonoBehaviour
{
    public AchievmentsObject achievment;
    public TextMeshProUGUI name;
    public TextMeshProUGUI description;
    public bool unlocked;

    public void Update()
    {
        name.text = achievment.ID;
        description.text = achievment.description;
        unlocked = achievment.unlocked;

        if (unlocked)
        {
            Image image = GetComponent<Image>();
            image.color = Color.green;
        }
    }
}

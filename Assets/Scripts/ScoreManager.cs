using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager: MonoBehaviour
{
    public static TextMeshProUGUI score;

    public static int value = 0;

    private void Start()
    {
        score = GetComponent<TextMeshProUGUI>();
    }

    public static void Score(int num)
    {
        value = value + num;
        score.text = value.ToString();
    }
}

using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class FinalScore : MonoBehaviour
{
    public TextMeshProUGUI finalscore;
    void Start()
    {
        finalscore.text = ScoreManager.value.ToString();
    }

   
}

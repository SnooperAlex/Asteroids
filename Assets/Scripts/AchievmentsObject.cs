using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Achievment", menuName = "Achievment")]
public class AchievmentsObject : ScriptableObject
{
    public string ID;

    public string description;

    public bool unlocked;
}

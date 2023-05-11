using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Snowflake", menuName = "Snowflake")]
public class Snowflake : ScriptableObject
{
   public new string name;

   public int speed;

   public Sprite artwork;
   
   public int health;

}

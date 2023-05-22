using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Profiling;

public class TimePositioned : MonoBehaviour
{
   public static bool itemPicked = false;
   public bool isRewinding = false;

   private List<Location> positions;
   private void Start()
   {
      positions = new List<Location>();
   }

   private void Update()
   {
      if (itemPicked)
      {
         StartRewind();
      }

      else
      {
         StopRewind();
      }
   }
   
   void FixedUpdate()
   {
      if (isRewinding)
      {
         Rewind();
      }
      else
      {
         Record();
      }
   }

   void Rewind()
   {
      if (positions.Count > 0)
      {
         Location location = positions[0];
         transform.position = location.position;
         transform.rotation = location.rotation;
         positions.RemoveAt(0); 
      }
      else
      {
         StopRewind();
      }
     
   }
   void Record()
   {
      if (positions.Count > Mathf.Round(5f / Time.fixedDeltaTime))
      {
         positions.RemoveAt(positions.Count - 1);
      }
      positions.Insert(0, new Location(transform.position, transform.rotation));
   }

   void StartRewind()
   {
      isRewinding = true;
      
   }

   void StopRewind()
   {
      isRewinding = false;
      
   }
}

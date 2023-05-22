using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewindClock : MonoBehaviour
{
    private ParticleSystem partSys;
    public void Start()
    {
        partSys = GetComponent<ParticleSystem>();
        partSys.Stop();
    }

    public void OnCollisionEnter2D(Collision2D col)
    {
        
        if (col.gameObject.tag == "Player")
        {
            partSys.Play();
            TimePositioned.itemPicked = true;
            StartCoroutine(TimeCoroutine());
        }
       
        
    }
    
    IEnumerator TimeCoroutine()
    {
        Debug.Log("start coro");
        yield return new WaitForSeconds (2.0f);
        Debug.Log("stop coro");
        TimePositioned.itemPicked = false;
        Destroy(this.gameObject);
        
    }
    
   
}

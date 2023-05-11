using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class SnowflakeDisplay : MonoBehaviour
{
    public TextMeshPro text;
    
    public Snowflake snowf;

    public Sprite sprite;

    private SpriteRenderer sr;

    private Rigidbody2D rb;

    public float size;

    public float speed = 10.0f;


    private void Awake()
    {

        rb = GetComponent<Rigidbody2D>();
        sr = GetComponent<SpriteRenderer>();
    }

    private void Start()
    {
        
        sr.sprite = snowf.artwork;

        this.transform.eulerAngles = new Vector3(0.0f, 0.0f, Random.value * 360.0f);
        this.transform.localScale = Vector3.one * this.size;

        rb.mass = size * 10;
    }

    public void SetTrajectory(Vector2 direction)
    {
        rb.AddForce(direction * this.speed);
        
        Destroy(this.gameObject, 40.0f);
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "Bullet")
        {
            ScoreManager.Score(1);
            if(ScoreManager.value >= 5)
            {
                UnlockAchievment("0001");
            }
            Destroy(gameObject);
            Destroy(col.gameObject);
        }
    }
    
    private void UnlockAchievment(string ID)
    {
        AchievmentService achServ = FindObjectOfType<AchievmentService>();
        if (achServ)
        {
            achServ.GetComponent<AchievmentService>().UnlockAchievment(ID);
        }
    }
}

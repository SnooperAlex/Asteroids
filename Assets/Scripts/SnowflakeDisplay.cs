using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Random = UnityEngine.Random;


public class SnowflakeDisplay : MonoBehaviour
{
    public PlayerMovement player;
    public AchievmentsObject achievment1;

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
            if(ScoreManager.value >= 5 && achievment1.unlocked == false)
            {
                UnlockAchievment(achievment1);
            }
            int chance = Random.Range(1, 5);
            if (chance == 1)
            {
                GameObject powerUp = Instantiate(snowf.powerUpList[Random.Range(0,10)]);
                powerUp.transform.position = gameObject.transform.position;
            }
            
            Destroy(gameObject);
            Destroy(col.gameObject);
            
        }
        
        if (col.gameObject.tag == "Player")
        {
            player.loseHP();
            if (player.getHP() <= 0)
            {
                SceneManager.LoadScene("LostScene");
            }
            
        }
    }
    
    private void UnlockAchievment(AchievmentsObject achievment)
    {
        AchievmentService achServ = FindObjectOfType<AchievmentService>();
        if (achServ)
        {
            achServ.GetComponent<AchievmentService>().UnlockAchievment(achievment);
        }
    }
}

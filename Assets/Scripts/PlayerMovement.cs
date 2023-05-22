using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public AchievmentsObject achievment2;
    public Bullet bulletPrefab;
    
    public float speed = 10f;
    private float turnSpeed = 2.0f;
    private int hp = 10;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update(){
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Shoot();
        }

        if (hp == 10 && ScoreManager.value >= 50 && achievment2.unlocked == false) 
        {
            UnlockAchievment(achievment2);
        }
        
    }

    private void FixedUpdate(){
        if(Input.GetKey(KeyCode.W)){
            rb.AddForce(this.transform.up * speed);
           
        }
        if(Input.GetKey(KeyCode.A)){
             rb.AddTorque(turnSpeed);
        }
        if(Input.GetKey(KeyCode.D)){
            rb.AddTorque(-turnSpeed);
        }
    }

    private void Shoot()
    {
        Bullet bullet = Instantiate(this.bulletPrefab, this.transform.position, this.transform.rotation);
        bullet.Project(this.transform.up);
    }

    public void loseHP()
    {
        Debug.Log("ouch");
        hp -= 1;
    }

    public int getHP()
    {
        return hp;
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

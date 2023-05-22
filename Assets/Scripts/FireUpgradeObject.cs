using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FireUpgradeObject : MonoBehaviour
{
    public Bullet bulletPrefab;
    public SpriteRenderer sprite;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            sprite.enabled = false;
            StartCoroutine(ShootCourutine(collision.gameObject));
            
            
        }
    }

    IEnumerator ShootCourutine(GameObject player)
    {
        for (int i = 0; i < 25; i++)
        {
            Bullet bullet = Instantiate(this.bulletPrefab, player.transform.position, player.transform.rotation);
            bullet.Project(player.transform.up);

            yield return new WaitForSeconds(0.05f);
        }
        
        Destroy(gameObject);
    }
}

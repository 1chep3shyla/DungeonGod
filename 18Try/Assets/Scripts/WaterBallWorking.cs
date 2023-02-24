using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBallWorking : MonoBehaviour
{
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            enemy.gameObject.GetComponent<EnemyScript>().health -= (int)((float)player.GetComponent<WaterBall>()._damage + (float)player.GetComponent<WaterBall>()._damage * player.GetComponent<AddDamage>().addDMG);
        }
    }
}

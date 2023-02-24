using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterCullerScript : MonoBehaviour
{
    Transform target;
    float timeSpawn;
    GameObject player;
    public float attack;
    
    void Start()
    {
        target = gameObject.transform;
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        attack -= Time.deltaTime;
        timeSpawn += Time.deltaTime;
        if (timeSpawn >= 5)
        {
            Destroy(gameObject);
        }
    }
    private void OnTriggerStay2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            enemy.transform.position = Vector2.MoveTowards(enemy.transform.position, target.position, (enemy.GetComponent<EnemyScript>().speed + 1) * Time.deltaTime);
            if (attack <= 0f)
            {
                attack = 0.1f;
                enemy.GetComponent<EnemyScript>().health -= (int)((float)player.GetComponent<WaterCuller>()._damage / 10 + (float)player.GetComponent<WaterCuller>()._damage * player.GetComponent<AddDamage>().addDMG);
            }
        }
    }
}

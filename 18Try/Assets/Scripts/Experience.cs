using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Experience : MonoBehaviour
{
    public int expGive;
    public float speed;
    public float timeLife;
    Transform target;

    void Update()
    {
        
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        if (Time.timeScale == 1.0f)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            timeLife += Time.deltaTime;
        }
        if (timeLife >= 60f)
        {
            Destroy(gameObject);
        }

    }
        private void OnTriggerEnter2D(Collider2D Player)
        {
            if (Player.gameObject.tag == "Player")
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>()._curStats[1] += expGive;
                Destroy(gameObject);

            }
        }

    private void OnTriggernExit2D(Collision2D Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            speed = 0f;
        }
    }
}




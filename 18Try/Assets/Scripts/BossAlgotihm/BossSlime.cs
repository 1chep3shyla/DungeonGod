using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSlime : MonoBehaviour
{
    public EnemyScript SlimeBoss;
    public float attack;
    public GameObject GM;

    void Update()
    {
        attack -= Time.deltaTime;
        if (SlimeBoss.health <= 0)
        {
            Destroy(SlimeBoss.gameObject);
            if (GM.GetComponent<GameManager>()._playingTime <= 565)
            {
                GM.GetComponent<GameManager>()._playingTime = 565;
                GameObject.FindGameObjectWithTag("Player").GetComponent<achievements>().achievement[1] += 1;
                Destroy(SlimeBoss.gameObject);
            }
            else
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<achievements>().achievement[1] += 1;
                Destroy(SlimeBoss.gameObject);
            }
        }


    }
    private void OnTriggerStay2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            if (attack <= 0f)
            {
                if (player.gameObject.GetComponent<Shield>().Working != true || player.gameObject.GetComponent<Shield>().hpShield <= 0)
                {
                    player.GetComponent<PlayerStats>()._curStats[0] -= 2;
                    attack = 0.1f;
                }
                if (player.gameObject.GetComponent<Shield>().hpShield > 0)
                {
                    player.gameObject.GetComponent<Shield>().hpShield -= 2;
                    attack = 0.1f;
                }
            }

        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarFailingScript : MonoBehaviour
{
    public GameObject player;
    public int damage;
    public float timeIs;
    public float attack;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        attack -= Time.deltaTime;
        timeIs += Time.deltaTime;
        if (timeIs >= 4.5f)
        {
            Destroy(gameObject);
        }
        else
        {
            
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 0)
        {
            damage = 0;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 1)
        {
            damage = 40;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 2)
        {
            damage = 60;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 3)
        {
            damage = 80;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 4)
        {
            damage = 100;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 5)
        {
            damage = 140;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 6)
        {
            damage = 180;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 7)
        {
            damage = 220;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 8)
        {
            damage = 260;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 9)
        {
            damage = 300;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 10)
        {
            damage = 350;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 11)
        {
            damage = 400;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 12)
        {
            damage = 450;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 13)
        {
            damage = 500;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 14)
        {
            damage = 600;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 15)
        {
            damage = 700;
        }
    }

    private void OnTriggerStay2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            if (attack <= 0)
            {
                attack = 0.1f;
                enemy.GetComponent<EnemyScript>().health -= (int)((float)damage / 10 + (float)damage * player.GetComponent<AddDamage>().addDMG); 
            }
        }
    }
}

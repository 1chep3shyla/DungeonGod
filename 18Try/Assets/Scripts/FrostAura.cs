using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FrostAura : MonoBehaviour
{
    public int AuraDamage;
    public bool isWorking;
    public GameObject player;
    public float attack;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        attack -= Time.deltaTime;
        if (player.GetComponent<PlayerStats>()._spellsLevel[0] > 0)
        {
            isWorking = true;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 0)
        {
            AuraDamage = 0;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 1)
        {
            AuraDamage = 30;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 2)
        {
            AuraDamage = 50;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 3)
        {
            AuraDamage = 70;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 4)
        {
            AuraDamage = 90;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 5)
        {
            AuraDamage = 120;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 6)
        {
            AuraDamage = 150;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 7)
        {
            AuraDamage = 180;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 8)
        {
            AuraDamage = 210;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 9)
        {
            AuraDamage = 240;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 10)
        {
            AuraDamage = 270;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 11)
        {
            AuraDamage = 300;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 12)
        {
            AuraDamage = 330;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 13)
        {
            AuraDamage = 360;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 14)
        {
            AuraDamage = 400;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[0] == 15)
        {
            AuraDamage = 450;
        }
    }
    private void OnTriggerStay2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            if (isWorking == true)
            {
                if (attack <= 0)
                {
                    enemy.GetComponent<EnemyScript>().health -= (int)((float)AuraDamage /10 + (float)AuraDamage* player.GetComponent<AddDamage>().addDMG); 
                    attack = 0.1f;
                }
            }
        }
    }
}

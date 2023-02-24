using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthRegen : MonoBehaviour
{
    public GameObject player;
    public int healhtRegen;
    public float timeHeal;
    public GameObject partical;
    void Update()
    {
        timeHeal -= Time.deltaTime;
        if (timeHeal <= 0)
        {
            if (player.GetComponent<PlayerStats>()._curStats[0] < player.GetComponent<PlayerStats>()._stats[0])
            {
                player.GetComponent<PlayerStats>()._curStats[0] += healhtRegen;
                timeHeal = 0.1f;
            }
            if (player.GetComponent<PlayerStats>()._curStats[0] > player.GetComponent<PlayerStats>()._stats[0])
            {
                player.GetComponent<PlayerStats>()._curStats[0] = player.GetComponent<PlayerStats>()._stats[0];
                timeHeal = 0.1f;
            }
        }


        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 0)
        {
            healhtRegen = 0;
            partical.SetActive(false);
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 1)
        {
            healhtRegen = 1;
            partical.SetActive(true);
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 2)
        {
            healhtRegen = 2;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 3)
        {
            healhtRegen = 3;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 4)
        {
            healhtRegen = 4;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 5)
        {
            healhtRegen = 6;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 6)
        {
            healhtRegen = 8;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 7)
        {
            healhtRegen = 10;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 8)
        {
            healhtRegen = 12;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 9)
        {
            healhtRegen = 14;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 10)
        {
            healhtRegen = 17;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 11)
        {
            healhtRegen = 20;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 12)
        {
            healhtRegen = 23;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 13)
        {
            healhtRegen = 27;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 14)
        {
            healhtRegen = 30;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[0] == 15)
        {
            healhtRegen = 50;
        }
    }

}

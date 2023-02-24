using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vampirizm : MonoBehaviour
{
    public int hpReturn;
    public GameObject player;
    public GameObject partical;
    
    // Update is called once per frame
    void Update()
    {
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] > 0)
        {
            partical.SetActive(true);
        }
        else
        {
            partical.SetActive(false);
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 0)
        {
            hpReturn = 0;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 1)
        {
            hpReturn = 5;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 2)
        {
            hpReturn = 10;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 3)
        {
            hpReturn = 15;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 4)
        {
            hpReturn = 20;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 5)
        {
            hpReturn = 25;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 6)
        {
            hpReturn = 35;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 7)
        {
            hpReturn = 55;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 8)
        {
            hpReturn = 65;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 9)
        {
            hpReturn = 75;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 10)
        {
            hpReturn = 85;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 11)
        {
            hpReturn = 100;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 12)
        {
            hpReturn = 115;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 13)
        {
            hpReturn = 130;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 14)
        {
            hpReturn = 140;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[6] == 15)
        {
            hpReturn = 150;
        }
    }
}

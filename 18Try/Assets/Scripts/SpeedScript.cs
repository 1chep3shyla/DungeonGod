using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedScript : MonoBehaviour
{
  
    public GameObject player;
    void Update()
    {
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 0)
        {
            player.GetComponent<PlayerMoving>().speed = 5.5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 1)
        {
            player.GetComponent<PlayerMoving>().speed = 6f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 2)
        {
            player.GetComponent<PlayerMoving>().speed = 6.10f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 3)
        {
            player.GetComponent<PlayerMoving>().speed = 6.20f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 4)
        {
            player.GetComponent<PlayerMoving>().speed = 6.30f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 5)
        {
            player.GetComponent<PlayerMoving>().speed = 6.40f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 6)
        {
            player.GetComponent<PlayerMoving>().speed = 6.50f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 7)
        {
            player.GetComponent<PlayerMoving>().speed = 6.55f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 8)
        {
            player.GetComponent<PlayerMoving>().speed = 6.60f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 9)
        {
            player.GetComponent<PlayerMoving>().speed = 6.75f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 10)
        {
            player.GetComponent<PlayerMoving>().speed = 6.80f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 11)
        {
            player.GetComponent<PlayerMoving>().speed = 6.85f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 12)
        {
            player.GetComponent<PlayerMoving>().speed = 6.90f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 13)
        {
            player.GetComponent<PlayerMoving>().speed = 6.95f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 14)
        {
            player.GetComponent<PlayerMoving>().speed = 7f;
        }

        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[4] == 15)
        {
            player.GetComponent<PlayerMoving>().speed = 7.5f;
        }

    }
}

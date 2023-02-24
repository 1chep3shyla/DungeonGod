using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hitGolem : MonoBehaviour
{
    public int damage;
    private void OnTriggerStay2D(Collider2D Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            Player.gameObject.GetComponent<PlayerStats>().Hitted();
            Player.gameObject.GetComponent<Shield>().hpShield = 0;
            Player.gameObject.GetComponent<PlayerStats>()._curStats[0] -= damage;
            Destroy(gameObject);
        }
    }
}

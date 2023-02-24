using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterBall : MonoBehaviour
{
    public GameObject _waterBall;
    public bool Working;
    public int _damage;
    public int _count;
    public int _curCount;
    public GameObject player;
    public GameObject[] waterCount = new GameObject[10];
    public AudioSource waterBallSource;
    public AudioClip waterballFx;


    void Update()
    {
        if (_curCount < _count && player.GetComponent<PlayerStats>()._spellsLevel[5] != 0)
        {
            SpawnWater();
        }
        player = GameObject.FindGameObjectWithTag("Player");
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 0)
        {
            Working = false;
            _damage = 0;
            _count = 0;
            _curCount = 0;

        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 1)
        {
            _damage = 10;
            _count = 1;

        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 2)
        {
            _damage = 15;
            _count = 1;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 3)
        {
            _damage = 25;
            _count = 2;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 4)
        {
            _damage = 30;
            _count = 2;

        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 5)
        {
            _damage = 50;
            _count = 2;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 6)
        {
            _damage = 75;
            _count = 2;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 7)
        {
            _damage = 100;
            _count = 3;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 8)
        {
            _damage = 95;
            _count = 3;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 9)
        {
            _damage = 125;
            _count = 3;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 10)
        {
            _damage = 150;
            _count = 4;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 11)
        {
            _damage = 150;
            _count = 4;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 12)
        {
            _damage = 175;
            _count = 4;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 13)
        {
            _damage = 175;
            _count = 5;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 14)
        {
            _damage = 200;
            _count = 5;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[5] == 15)
        {
            _damage = 200;
            _count = 8;
        }
    }
    void SpawnWater()
    {
        _curCount++;
        GameObject copy = (Instantiate(_waterBall, transform.position, Quaternion.identity));
        waterCount[_curCount] = copy;

        if (waterCount[0] != null)
        {
            waterCount[0].GetComponent<AroundMoving>().angle = 6.3f;//+
        }
        if (waterCount[1] != null)
        {
            waterCount[1].GetComponent<AroundMoving>().angle = 6.3f / 2f;//+ 3.15
        }
        if (waterCount[2] != null)
        {
            waterCount[2].GetComponent<AroundMoving>().angle = 6.3f / 4f; // 1.575
        }
        if (waterCount[3] != null)
        {
            waterCount[3].GetComponent<AroundMoving>().angle = 4.725f;
        }
        if (waterCount[4] != null)
        {
            waterCount[4].GetComponent<AroundMoving>().angle = 6.3f / 8f;
        }
        if (waterCount[5] != null)
        {
            waterCount[5].GetComponent<AroundMoving>().angle = 3.9375f;
        }
        if (waterCount[6] != null)
        {
            waterCount[6].GetComponent<AroundMoving>().angle = 6.3f / 2.5f;
        }
        if (waterCount[7] != null)
        {
            waterCount[7].GetComponent<AroundMoving>().angle = 5.5125f;
        }
        waterBallSource.pitch = Random.Range(0.95f, 1.05f);
        waterBallSource.PlayOneShot(waterballFx);
    }
}


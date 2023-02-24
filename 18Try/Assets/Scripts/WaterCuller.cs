using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WaterCuller : MonoBehaviour
{
    public GameObject waterCuller;
    public float _timeSpawn;
    public float _curTime;
    public bool Working;
    public int _damage;
    public int _count;
    public GameObject player;
    public Slider coldown;
    public GameObject spellIcon;
    


    void Update()
    {
        if (Working == true)
        {
            _curTime -= Time.deltaTime;
            if (_curTime <= 0)
            {
                StartCoroutine(SpawnWaterCuller());
                _curTime = _timeSpawn;
            }
            if (coldown != null)
            {
                coldown.maxValue = _timeSpawn;
                coldown.value = _curTime;
            }
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 0)
        {
            _curTime = 0f;
            Working = false;
            _damage = 0;
            _count = 0;
            if (coldown != null)
            {
                coldown.value = 0;
            }
            coldown = null;
            spellIcon = null;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 1)
        {
            _damage = 10;
            _count = 1;
            _timeSpawn = 12f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 2)
        {
            _damage = 15;
            _count = 1;
            _timeSpawn = 12f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 3)
        {
            _damage = 20;
            _count = 1;
            _timeSpawn = 11f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 4)
        {
            _damage = 25;
            _count = 2;
            _timeSpawn = 11f;

        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 5)
        {
            _damage = 30;
            _count = 2;
            _timeSpawn = 11f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 6)
        {
            _damage = 35;
            _count = 2;
            _timeSpawn = 11f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 7)
        {
            _damage = 45;
            _count = 2;
            _timeSpawn = 10f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 8)
        {
            _damage = 55;
            _count = 3;
            _timeSpawn = 10f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 9)
        {
            _damage = 65;
            _count = 3;
            _timeSpawn = 10f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 10)
        {
            _damage = 90;
            _count = 3;
            _timeSpawn = 10f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 11)
        {
            _damage = 110;
            _count = 3;
            _timeSpawn = 9f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 12)
        {
            _damage = 140;
            _count = 3;
            _timeSpawn = 9f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 13)
        {
            _damage = 170;
            _count = 4;
            _timeSpawn = 9f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 14)
        {
            _damage = 200;
            _count = 4;
            _timeSpawn = 9f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[6] == 15)
        {
            _damage = 250;
            _count = 4;
            _timeSpawn = 9f;
        }
    }

    IEnumerator SpawnWaterCuller()
    {
        for (int i = 0; i < _count; i++)
        {
            Transform enemy;
            enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
            GameObject copy = (Instantiate(waterCuller, enemy.position, Quaternion.identity));
            yield return new WaitForSeconds(0.5f);
        }
        

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireClamp : MonoBehaviour
{
    public bool workingClamp;
    public int damageClamp;
    public GameObject player;
    public Slider coldownClamp;
    public GameObject spellIcon;
    public ParticleSystem effect;
    public float _timeSpawn;
    
    public float _curTime;

    void Start()
    {
        _curTime = _timeSpawn;
    }

    
    void Update()
    {
        if (workingClamp== true)
        {
            _curTime -= Time.deltaTime;
            if (_curTime < 0)
            {
                clamped();
                _curTime = _timeSpawn;
            }
            if (coldownClamp != null)
            {
                coldownClamp.maxValue = _timeSpawn;
                coldownClamp.value = _curTime;
            }
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 0)
        {
            damageClamp = 0;
            _timeSpawn = 5f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 1)
        {
            damageClamp = 35;
            _timeSpawn = 4f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 2)
        {
            damageClamp = 75;
            _timeSpawn = 4f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 3)
        {
            damageClamp = 150;
            _timeSpawn = 4f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 4 )
        {
            damageClamp = 225;
            _timeSpawn = 4f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 5)
        {
            damageClamp = 300;
            _timeSpawn = 4f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 6)
        {
            damageClamp = 350;
            _timeSpawn = 4f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 7)
        {
            damageClamp = 300;
            _timeSpawn = 4f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 8)
        {
            damageClamp = 350;
            _timeSpawn = 3.5f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 9)
        {
            damageClamp = 400;
            _timeSpawn = 3.5f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 10)
        {
            damageClamp = 450;
            _timeSpawn = 3.5f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 11)
        {
            damageClamp = 500;
            _timeSpawn = 3f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 12)
        {
            damageClamp = 600;
            _timeSpawn = 3f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 13)
        {
            damageClamp = 700;
            _timeSpawn = 3f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 14)
        {
            damageClamp =  800;
            _timeSpawn = 2.5f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[4] == 15)
        {
            damageClamp = 1000;
            _timeSpawn = 2f;
        }



    }
    public void clamped()
    {
        effect.Play();


    }
    public void OnTriggerStay2D(Collider2D enemy)
    {

        if (enemy.gameObject.tag == "Enemy")
        {

            if (_curTime <= 0.02)
            {
                enemy.GetComponent<EnemyScript>().health -= (int)((float)damageClamp + (float)damageClamp * player.GetComponent<AddDamage>().addDMG);
            }
        }

    }
    
    
}

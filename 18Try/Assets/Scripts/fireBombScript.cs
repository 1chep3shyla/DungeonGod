using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireBombScript : MonoBehaviour
{
    public int damageBomb;
    public float _curTime;
    public float Timer;
    public GameObject player;
    public AudioSource fireBombSource;
    public AudioClip Explosion;
    public GameObject particle;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        fireBombSource = GameObject.Find("/fx/explosionFX").GetComponent<AudioSource>();
        Timer = 2f;
    }
    void Update()
    {
        Timer -= Time.deltaTime;
        if (Timer <= 0f)
        {
            _curTime += Time.deltaTime;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 0)
        {
            damageBomb = 40;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 1)
        {
            damageBomb = 90;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 2)
        {
            damageBomb = 130;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 3)
        {
            damageBomb = 180;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 4)
        {
            damageBomb = 200;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 5)
        {
            damageBomb = 260;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 6)
        {
            damageBomb = 300;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 7)
        {
            damageBomb = 360;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 8)
        {
            damageBomb = 420;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 9)
        {
            damageBomb = 480;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 10)
        {
            damageBomb = 600;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 11)
        {
            damageBomb = 750;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 12)
        {
            damageBomb = 900;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 13)
        {
            damageBomb = 1150;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 14)
        {
            damageBomb = 1300;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 15)
        {
            damageBomb = 1500;
        }

    }

    public void OnTriggerStay2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {

            if (Timer <= 0f)
            {
                if (_curTime >= 0.015f)
                {
                    
                    enemy.GetComponent<EnemyScript>().health -= (int)((float)damageBomb + (float)damageBomb * player.GetComponent<AddDamage>().addDMG);
                    fireBombSource.PlayOneShot(Explosion);
                    GameObject copy = (Instantiate(particle, transform.position, Quaternion.identity));
                    copy.GetComponent<ParticleSystem>().Play();
                    Destroy(gameObject.transform.parent.gameObject);

                }
            }
        }
    }
}

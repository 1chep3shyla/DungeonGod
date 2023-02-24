using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBallScript : MonoBehaviour
{
    public GameObject _fireball;
    public float _timeSpawn;
    public float _curTime;
    public bool Working;
    public int _damage;
    public int _count;
    public GameObject player;
    public Slider coldown;
    public GameObject spellIcon;
    public GameObject GM;
    public AudioSource fireballFX;
    public AudioClip fx;

    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GameController"); 
    }
    void Update()
    {
        if (Working == true)
        {
            _curTime -= Time.deltaTime;
            if (_curTime <= 0f)
            {
                if (GM.GetComponent<GameManager>()._gameIs == true)
                {
                    StartCoroutine(SpawnFireBall());
                    _curTime = _timeSpawn;
                }
                else
                {
                    _curTime = 0f;
                }
            }
            if (coldown != null)
            {
                coldown.maxValue = _timeSpawn;
                coldown.value = _curTime;
            }
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 0)
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
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 1)
        {
            _damage = 15;
            _count = 2;
            _timeSpawn = 3f;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 2)
        {
            _damage = 30;
            _count = 2;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 3)
        {
            _damage = 45;
            _count = 2;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 4)
        {
            _damage = 60;
            _count = 3;
            
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 5)
        {
            _damage = 80;
            _count = 3;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 6)
        {
            _damage = 100;
            _count = 3;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 7)
        {
            _damage = 120;
            _count = 3;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 8)
        {
            _damage = 120;
            _count = 4;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 9)
        {
            _damage = 140;
            _count = 4;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 10)
        {
            _damage = 160;
            _count = 5;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 11)
        {
            _damage = 170;
            _count = 5;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 12)
        {
            _damage = 200;
            _count = 5;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 13)
        {
            _damage = 225;
            _count = 6;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 14)
        {
            _damage = 250;
            _count = 6;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[3] == 15)
        {
            _damage = 300;
            _count = 7;
        }
    }
    IEnumerator SpawnFireBall()
    {
        for (int i = 0; i < _count; i++)
        {
            GameObject copy = (Instantiate(_fireball, transform.position, Quaternion.identity));
            fireballFX.pitch = Random.Range(0.95f, 1.10f);
            fireballFX.PlayOneShot(fx);
            yield return new WaitForSeconds(0.2f);
        }
        
    }
}

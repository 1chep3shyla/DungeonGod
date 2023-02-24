using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FireBombSpawner : MonoBehaviour
{
    public GameObject player;
    public Slider coldown;
    public float _timeSpawn;
    public float _curTime;
    public GameObject spellIcon;
    public GameObject FireBomb;
    public GameObject GM;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        GM = GameObject.FindGameObjectWithTag("GameController");
        _curTime = 7f;
        _timeSpawn = 7f;
    }
    void Update()
    {
        if (player.GetComponent<PlayerStats>()._spellsLevel[2] > 0)
        {
            _curTime -= Time.deltaTime;
            if (_curTime <= 0)
            {
                if (GM.GetComponent<GameManager>()._gameIs = true)
                {
                    GameObject copy = (Instantiate(FireBomb, transform.position, Quaternion.identity));
                    _curTime = _timeSpawn;
                }
                else
                {
                    _curTime = 0f;
                }
            }
            if (player.GetComponent<PlayerStats>()._spellsLevel[2] == 0 )
            {
                _curTime = _timeSpawn;
            }
            if (coldown != null)
            {
                coldown.maxValue = _timeSpawn;
                coldown.value = _curTime;
            }
        }
    }
}

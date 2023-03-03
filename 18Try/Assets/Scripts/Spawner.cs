using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject[] _enemy;
    public GameObject _gm;
    public GameObject _player;
    public int _count;
    public float _spawnTime;
    public bool trigger;
    public GameObject SkillPanel;


    void Update()
    {
        if (_gm.GetComponent<GameManager>()._gameIs == true && SkillPanel.activeInHierarchy == false)
        {
            if (trigger == false)
            {
                _spawnTime += Time.deltaTime;
            }
        }
        float timeToSpawn = Random.Range(1.5f, 2.5f);

        if (_spawnTime >= timeToSpawn)
        {
            if (_gm.GetComponent<GameManager>()._playingTime < 20f)
            {
                GameObject copy = (Instantiate(_enemy[0], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 20f && _gm.GetComponent<GameManager>()._playingTime < 45f)
            {
                GameObject copy = (Instantiate(_enemy[1], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 45f && _gm.GetComponent<GameManager>()._playingTime < 60f)
            {
                GameObject copy = (Instantiate(_enemy[2], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 60f && _gm.GetComponent<GameManager>()._playingTime < 100f)
            {
                GameObject copy = (Instantiate(_enemy[3], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 100f && _gm.GetComponent<GameManager>()._playingTime < 135f)
            {
                GameObject copy = (Instantiate(_enemy[4], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 165 && _gm.GetComponent<GameManager>()._playingTime < 200)
            {
                GameObject copy = (Instantiate(_enemy[5], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 200 && _gm.GetComponent<GameManager>()._playingTime < 230)
            {
                GameObject copy = (Instantiate(_enemy[6], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 230 && _gm.GetComponent<GameManager>()._playingTime < 260)
            {
                GameObject copy = (Instantiate(_enemy[7], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 300 && _gm.GetComponent<GameManager>()._playingTime < 330)
            {
                GameObject copy = (Instantiate(_enemy[8], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 330 && _gm.GetComponent<GameManager>()._playingTime < 360)
            {
                GameObject copy = (Instantiate(_enemy[9], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 360 && _gm.GetComponent<GameManager>()._playingTime < 390)
            {
                GameObject copy = (Instantiate(_enemy[10], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 440 && _gm.GetComponent<GameManager>()._playingTime < 460)
            {
                GameObject copy = (Instantiate(_enemy[11], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 460 && _gm.GetComponent<GameManager>()._playingTime < 490)
            {
                GameObject copy = (Instantiate(_enemy[12], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 490 && _gm.GetComponent<GameManager>()._playingTime < 520)
            {
                GameObject copy = (Instantiate(_enemy[13], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 565 && _gm.GetComponent<GameManager>()._playingTime < 600)
            {
                GameObject copy = (Instantiate(_enemy[14], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 600 && _gm.GetComponent<GameManager>()._playingTime < 640)
            {
                GameObject copy = (Instantiate(_enemy[15], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 690 && _gm.GetComponent<GameManager>()._playingTime < 730)
            {
                GameObject copy = (Instantiate(_enemy[16], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 730 && _gm.GetComponent<GameManager>()._playingTime < 770)
            {
                GameObject copy = (Instantiate(_enemy[17], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 770 && _gm.GetComponent<GameManager>()._playingTime < 800)
            {
                GameObject copy = (Instantiate(_enemy[16], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 800 && _gm.GetComponent<GameManager>()._playingTime < 830)
            {
                GameObject copy = (Instantiate(_enemy[17], transform.position, Quaternion.identity));
            }
            if (_gm.GetComponent<GameManager>()._playingTime >= 830 && _gm.GetComponent<GameManager>()._playingTime < 860)
            {
                GameObject copy = (Instantiate(_enemy[18], transform.position, Quaternion.identity));
            }
            _spawnTime = 0f;
                _count += 1;
        }
    }
}

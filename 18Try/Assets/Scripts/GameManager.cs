using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public bool _gameIs;
    public float _playingTime;
    public GameObject Panel;
    public GameObject Player;
    public bool pause;
    public Text[] _textPlayingTime;
    public bool[] bossIs;
    public GameObject SkillChoose;

    void Update()
    {
        if (_gameIs == true && SkillChoose.activeInHierarchy == false)
        {
            _playingTime += Time.deltaTime;
        }
        _textPlayingTime[0].text = " " + _playingTime.ToString("0.00");
        _textPlayingTime[1].text = " " + _playingTime.ToString("0.00");
    }
    
    public void Pause()
    {
        Time.timeScale = 0f;
        Panel.SetActive(true);
        pause = true;
    }
    
    public void Restart()
    {
        _gameIs = false;
        Time.timeScale = 1f;
        Panel.SetActive(false);
        Player.transform.localPosition = new Vector2(0, 0);
        pause = false;
        _playingTime = 0f;
        for (var i = 0; i < bossIs.Length; i++)
        {
            bossIs[i] = false;
        }
    }

    public void Continue()
    {
        if (SkillChoose.activeInHierarchy == false)
        {
            Time.timeScale = 1f;
        }
        Panel.SetActive(false);
        pause = false;
    }
    
    public void Home()
    {
        Player.transform.localPosition = new Vector2(0, 0);
        Time.timeScale = 1f;
        _playingTime = 0f;
        _gameIs = false;
        pause = false;
    }
}

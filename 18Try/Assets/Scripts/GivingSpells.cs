using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GivingSpells : MonoBehaviour
{
    public GameObject _player;
    public GameObject _skillPanel;
    public GameObject[] _slot;
    public Sprite[] fullSpellIs = new Sprite[8];
    public GameObject GM;
    public bool first;
    void Update()
    {

        if (_player.GetComponent<PlayerStats>()._curStats[1] >= _player.GetComponent<PlayerStats>()._stats[1])
        {
            _skillPanel.SetActive(true);
            if (Time.timeScale != 0 && GM.GetComponent<GameManager>()._gameIs == true)
            {
                _player.GetComponent<PlayerStats>().LevelUp();
            }
            _player.GetComponent<PlayerStats>()._curStats[1] = 0;
            _player.GetComponent<PlayerStats>()._stats[1] += _player.GetComponent<PlayerStats>()._stats[1] / 8;
            rollSkill();
            if (first == true)
            {
                StartCoroutine(RollingAttack());
            }
            else if (first == false && _player.GetComponent<PlayerStats>()._isSprites[7].GetComponent<Image>().sprite == _player.GetComponent<PlayerStats>().defaultSprite)
            {
                StartCoroutine(Rolling());
            }
            if (_player.GetComponent<PlayerStats>()._isSprites[7].GetComponent<Image>().sprite != _player.GetComponent<PlayerStats>().defaultSprite)
            {
                StartCoroutine(FullSpells());
            }
            if (GM.GetComponent<GameManager>()._gameIs == true)
            {
                Time.timeScale = 0f;
            }

        }
        for (int i = 0; i < fullSpellIs.Length; i++)
        {
            fullSpellIs[i] = _player.GetComponent<PlayerStats>()._isSprites[i].GetComponent<Image>().sprite;
        }

    }

    public void rollSkill()
    {



    }
    IEnumerator RollingAttack()
    {
        first = false;
        _slot[0].GetComponent<Image>().sprite = null;
        _slot[1].GetComponent<Image>().sprite = null;
        _slot[2].GetComponent<Image>().sprite = null;

        int random = Random.Range(0, _player.GetComponent<PlayerStats>()._spellsLevel.Length);
        if (random == 0)
        {
            _slot[0].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[4];
        }
        if (random == 1)
        {
            _slot[0].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[5];
        }
        if (random == 2)
        {
            _slot[0].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[6];
        }
        if (random == 3)
        {
            _slot[0].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[7];
        }
        if (random == 4)
        {
            _slot[0].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[8];
        }
        if (random == 5)
        {
            _slot[0].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[10];
        }
        if (random == 6)
        {
            _slot[0].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[11];
        }
        _slot[0].GetComponent<Animator>().Play("buttonAnim");
        do
        {
            random = Random.Range(0, _player.GetComponent<PlayerStats>()._spellsLevel.Length);
            if (random == 0)
            {
                _slot[1].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[4];
            }
            if (random == 1)
            {
                _slot[1].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[5];
            }
            if (random == 2)
            {
                _slot[1].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[6];
            }
            if (random == 3)
            {
                _slot[1].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[7];
            }
            if (random == 4)
            {
                _slot[1].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[8];
            }
            if (random == 5)
            {
                _slot[1].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[10];
            }
            if (random == 6)
            {
                _slot[1].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[11];
            }
            _slot[1].GetComponent<Animator>().Play("buttonAnim");
        }
        while (_slot[1].GetComponent<Image>().sprite == _slot[0].GetComponent<Image>().sprite || _slot[1].GetComponent<Image>().sprite == _slot[2].GetComponent<Image>().sprite);

        do
        {
            random = Random.Range(0, _player.GetComponent<PlayerStats>()._spellsLevel.Length);
            if (random == 0)
            {
                _slot[2].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[4];
            }
            if (random == 1)
            {
                _slot[2].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[5];
            }
            if (random == 2)
            {
                _slot[2].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[6];
            }
            if (random == 3)
            {
                _slot[2].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[7];
            }
            if (random == 4)
            {
                _slot[2].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[8];
            }
            if (random == 5)
            {
                _slot[2].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[10];
            }
            if (random == 6)
            {
                _slot[2].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[11];
            }
            _slot[2].GetComponent<Animator>().Play("buttonAnim");
        }
        while (_slot[2].GetComponent<Image>().sprite == _slot[1].GetComponent<Image>().sprite || _slot[2].GetComponent<Image>().sprite == _slot[0].GetComponent<Image>().sprite);
        yield return new WaitForSeconds(0f);
    }
    IEnumerator Rolling()
    {
        _slot[0].GetComponent<Image>().sprite = null;
        _slot[1].GetComponent<Image>().sprite = null;
        _slot[2].GetComponent<Image>().sprite = null;

        int random = Random.Range(0, 12);
        _slot[0].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[random];
        _slot[0].GetComponent<Animator>().Play("buttonAnim");
        do
        {
            random = Random.Range(0, 12);
            _slot[1].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[random];
            _slot[1].GetComponent<Animator>().Play("buttonAnim");
        }
        while (_slot[0].GetComponent<Image>().sprite == _player.GetComponent<PlayerStats>()._chooseSprites[random]);

        do
        {
            random = Random.Range(0, 12);
            _slot[2].GetComponent<Image>().sprite = _player.GetComponent<PlayerStats>()._chooseSprites[random];
            _slot[2].GetComponent<Animator>().Play("buttonAnim");
        }
        while (_slot[0].GetComponent<Image>().sprite ==_player.GetComponent<PlayerStats>()._chooseSprites[random] || _slot[1].GetComponent<Image>().sprite == _player.GetComponent<PlayerStats>()._chooseSprites[random]);
        yield return new WaitForSeconds(0f);
    }
    IEnumerator FullSpells()
    {
        _slot[0].GetComponent<Image>().sprite = null;
        _slot[1].GetComponent<Image>().sprite = null;
        _slot[2].GetComponent<Image>().sprite = null;

        int random = Random.Range(0, 7);
        _slot[0].GetComponent<Image>().sprite = fullSpellIs[random];
        _slot[0].GetComponent<Animator>().Play("buttonAnim");
        do
        {
            random = Random.Range(0, 7);
            _slot[1].GetComponent<Image>().sprite = fullSpellIs[random];
            _slot[1].GetComponent<Animator>().Play("buttonAnim");
        }
        while (_slot[0].GetComponent<Image>().sprite == fullSpellIs[random]);

        do
        {   
            random = Random.Range(0, 7);
            _slot[2].GetComponent<Image>().sprite = fullSpellIs[random];
            _slot[2].GetComponent<Animator>().Play("buttonAnim");
        }
        while (_slot[0].GetComponent<Image>().sprite == fullSpellIs[random] || _slot[1].GetComponent<Image>().sprite ==fullSpellIs[random]);
        yield return new WaitForSeconds(0f);
    }
}


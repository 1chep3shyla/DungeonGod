using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class StarFailingWorking : MonoBehaviour
{
    public GameObject player;
    public GameObject SFprefab;
    public float timeAppear;
    public float curTime;
    public Slider coldown;
    public GameObject spellIcon;
    public AudioSource starSource;
    public AudioClip starClip;

    void Update()
    {
        if (player.GetComponent<PlayerStats>()._spellsLevel[1] > 0)
        {
            curTime -= Time.deltaTime;
        }
        else
        {
            timeAppear = 10f;
        }
        if (coldown != null)
        {
            coldown.maxValue = timeAppear;
            coldown.value = curTime;
        }
        if (curTime <= 0f && player.GetComponent<PlayerStats>()._spellsLevel[1] > 0)
        {
            SpawnStar();
            curTime = timeAppear;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 0)
        {
            timeAppear = 10f;
            curTime = 10f;
            if (coldown != null)
            {
                coldown.value = 0;
            }
            coldown = null;
            spellIcon = null;
        }
        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 1)
        {
            timeAppear = 10f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 2)
        {
            timeAppear = 10f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 3)
        {
            timeAppear = 10f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 4)
        {
            timeAppear = 10f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 5)
        {
            timeAppear = 9f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 6)
        {
            timeAppear = 9f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 7)
        {
            timeAppear = 9f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 8)
        {
            timeAppear = 8f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 9)
        {
            timeAppear = 8f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 10)
        {
            timeAppear = 8f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 11)
        {
            timeAppear = 8f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 12)
        {
            timeAppear = 7f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 13)
        {
            timeAppear = 7f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 14)
        {
            timeAppear = 7f;
        }

        if (player.GetComponent<PlayerStats>()._spellsLevel[1] == 15)
        {
            timeAppear = 6f;
        }
    }
    void SpawnStar()
    {
        Transform enemy;
        enemy = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        GameObject copy = (Instantiate(SFprefab, enemy.position, Quaternion.identity));
        StartCoroutine(FXSpawn());
    }
    IEnumerator FXSpawn()
    {
        yield return new WaitForSeconds(0.15f);
        for (int i = 0; i < 14; i++)
        {
            starSource.PlayOneShot(starClip);
            yield return new WaitForSeconds(0.3f);
        }
    }
}

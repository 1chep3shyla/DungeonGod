using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossSpawner : MonoBehaviour
{
    public GameObject GameM;
    public GameObject[] Bosses;
    public ParticleSystem particalSpawn;

    void Update()
    {
        if (GameM.GetComponent<GameManager>()._playingTime >= 135f&& GameM.GetComponent<GameManager>().bossIs[0] == false)
        {
            particalSpawn.Play();
            GameObject copy = (Instantiate(Bosses[0], transform.position, Quaternion.identity));
            GameM.GetComponent<GameManager>().bossIs[0] = true;
        }
        if (GameM.GetComponent<GameManager>()._playingTime >= 265f && GameM.GetComponent<GameManager>().bossIs[1] == false)
        {
            particalSpawn.Play();
            GameObject copy = (Instantiate(Bosses[1], transform.position, Quaternion.identity));
            GameM.GetComponent<GameManager>().bossIs[1] = true;
        }
        if (GameM.GetComponent<GameManager>()._playingTime >= 395f && GameM.GetComponent<GameManager>().bossIs[2] == false)
        {
            particalSpawn.Play();
            GameObject copy = (Instantiate(Bosses[2], transform.position, Quaternion.identity));
            GameM.GetComponent<GameManager>().bossIs[2] = true;
        }
        if (GameM.GetComponent<GameManager>()._playingTime >= 525 && GameM.GetComponent<GameManager>().bossIs[3] == false)
        {
            particalSpawn.Play();
            GameObject copy = (Instantiate(Bosses[3], transform.position, Quaternion.identity));
            GameM.GetComponent<GameManager>().bossIs[3] = true;
        }
        if (GameM.GetComponent<GameManager>()._playingTime >= 650 && GameM.GetComponent<GameManager>().bossIs[4] == false)
        {
            particalSpawn.Play();
            GameObject copy = (Instantiate(Bosses[4], transform.position, Quaternion.identity));
            GameM.GetComponent<GameManager>().bossIs[4] = true;
        }
        if (GameM.GetComponent<GameManager>()._playingTime >= 860 && GameM.GetComponent<GameManager>().bossIs[5] == false)
        {
            particalSpawn.Play();
            GameObject copy = (Instantiate(Bosses[5], transform.position, Quaternion.identity));
            GameM.GetComponent<GameManager>().bossIs[5] = true;
        }
    }
}

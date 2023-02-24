using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieScript : MonoBehaviour
{
    public GameObject bull;
    public GameObject floorHit;
    public float timeUlt;
    public Animator animator;
    public AudioSource SpawnSource;
    public AudioClip SpawnClip;
    public GameObject GM;

    void Start()
    {
        animator = gameObject.GetComponent<Animator>();
        GM = GameObject.FindGameObjectWithTag("GameController");
        SpawnSource = GameObject.Find("/fx/fireballFX").GetComponent<AudioSource>();
    }
    void Update()
    {
        timeUlt -= Time.deltaTime;
        if (timeUlt <= 0f)
        {
            timeUlt = Random.Range(5f, 10f);
            StartCoroutine(Ulting());
        }
        if (gameObject.GetComponent<EnemyScript>().health <= 0)
        {
            if (GM.GetComponent<GameManager>()._playingTime <= 440f)
            {
                GM.GetComponent<GameManager>()._playingTime = 440f;
                GameObject.FindGameObjectWithTag("Player").GetComponent<achievements>().achievement[1] += 1;
                Destroy(gameObject);

            }
            else
            {
                GameObject.FindGameObjectWithTag("Player").GetComponent<achievements>().achievement[1] += 1;
                Destroy(gameObject);
            }
        }

    }
    IEnumerator Ulting()
    {
        animator.Play("enemy_14_ult");
        yield return new WaitForSeconds(0.6f);
        float a = 1f;
        for (int i = 0; i < 10; i++)
        {
            SpawnSource.pitch = Random.Range(0.65f, 0.95f);
            SpawnSource.PlayOneShot(SpawnClip);
            GameObject copyBull = (Instantiate(bull, transform.position , Quaternion.identity));
            copyBull.GetComponent<AroundMovingEnemy>().radius += a;
            copyBull.GetComponent<AroundMovingEnemy>().angle += a*2;
            a += 0.5f;
            copyBull.GetComponent<AroundMovingEnemy>().center = gameObject.transform;
            yield return new WaitForSeconds(0.5f);
        }
    }
}

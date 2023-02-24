using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemBoss : MonoBehaviour
{
    public float timeUlt;
    public int damageUlt;
    public GameObject hitFloor;
    public GameObject AttackBall;
    public Animator animator;
    public AudioSource hitSource;
    public AudioClip hitClip;
    public GameObject GM;
    void Start()
    {
        timeUlt = Random.Range(5f, 10f);
        animator = gameObject.GetComponent<Animator>();
        hitSource = GameObject.Find("/fx/hitfloorfx").GetComponent<AudioSource>();
        GM = GameObject.FindGameObjectWithTag("GameController");

    }

    // Update is called once per frame
    void Update()
    {
        timeUlt -= Time.deltaTime;
        if (timeUlt <= 0f)
        {
            timeUlt = Random.Range(7.5f, 15f);
            StartCoroutine(Ulting());
        }
        if (gameObject.GetComponent<EnemyScript>().health <= 0)
        {
            if (GM.GetComponent<GameManager>()._playingTime <= 690f)
            {
                GM.GetComponent<GameManager>()._playingTime = 690f;
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
        animator.Play("enemy_21_ult");
        yield return new WaitForSeconds(0.24f);
        if (hitSource != null)
        {
            hitSource.pitch = Random.Range(0.9f, 1.1f);
            hitSource.PlayOneShot(hitClip);
        }
        GameObject copy = (Instantiate(hitFloor, transform.position, Quaternion.identity));
        GameObject ball1 = (Instantiate(AttackBall, transform.position, Quaternion.identity));
        ball1.GetComponent<GolemWave>().posX = 0f;
        ball1.GetComponent<GolemWave>().posY = 0.05f;
        GameObject ball2 = (Instantiate(AttackBall, transform.position, Quaternion.identity));
        ball2.GetComponent<GolemWave>().posX = 0.05f;
        ball2.GetComponent<GolemWave>().posY = 0.05f;
        GameObject ball3 = (Instantiate(AttackBall, transform.position, Quaternion.identity));
        ball3.GetComponent<GolemWave>().posX = 0.05f;
        ball3.GetComponent<GolemWave>().posY = 0f;
        GameObject ball4 = (Instantiate(AttackBall, transform.position, Quaternion.identity));
        ball4.GetComponent<GolemWave>().posX = 0.05f;
        ball4.GetComponent<GolemWave>().posY = -0.05f;
        GameObject ball5 = (Instantiate(AttackBall, transform.position, Quaternion.identity));
        ball5.GetComponent<GolemWave>().posX = 0f;
        ball5.GetComponent<GolemWave>().posY = -0.05f;
        GameObject ball6 = (Instantiate(AttackBall, transform.position, Quaternion.identity));
        ball6.GetComponent<GolemWave>().posX = -0.05f;
        ball6.GetComponent<GolemWave>().posY = -0.05f;
        GameObject ball7 = (Instantiate(AttackBall, transform.position, Quaternion.identity));
        ball7.GetComponent<GolemWave>().posX = -0.05f;
        ball7.GetComponent<GolemWave>().posY = 0f;
        GameObject ball8 = (Instantiate(AttackBall, transform.position, Quaternion.identity));
        ball8.GetComponent<GolemWave>().posX = -0.05f;
        ball8.GetComponent<GolemWave>().posY = 0.05f;
        animator.Play("enemy_21_anim");
    }
}

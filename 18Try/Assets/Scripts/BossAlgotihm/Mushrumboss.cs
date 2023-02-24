using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mushrumboss : MonoBehaviour
{
    public float timeUlt;
    public int damageUlt;
    public GameObject deadMushroom;
    public Animator animator;
    public AudioSource Roar;
    public AudioSource ultSource;
    public AudioClip ultClip;
    public ParticleSystem suckPS;
    public GameObject GM;
    void Start()
    {
        timeUlt = Random.Range(5f, 10f);
        animator = gameObject.GetComponent<Animator>();
        ultSource = GameObject.Find("/fx/suckFx").GetComponent<AudioSource>();
        GM = GameObject.FindGameObjectWithTag("GameController");
        Roar = GameObject.Find("/fx/roarMuschroom").GetComponent<AudioSource>();
        if (Roar != null)
        {
            Roar.Play();
        }
    }

    // Update is called once per frame
    void Update()
    {
        timeUlt -= Time.deltaTime;
        if (timeUlt <= 0f)
        {
            timeUlt = Random.Range(7.5f, 10f);
            StartCoroutine(UltingMushroom());
        }
        if (gameObject.GetComponent<EnemyScript>().health <= 0)
        {
            if (GM.GetComponent<GameManager>()._playingTime <= 300f)
            {
                GM.GetComponent<GameManager>()._playingTime = 300f;
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
    IEnumerator UltingMushroom()
    {
        animator.Play("Enemy_10_ult");
        yield return new WaitForSeconds(0.21f);
        suckPS.Play();
        if (ultSource != null)
        {
            ultSource.PlayOneShot(ultClip);
        }
        yield return new WaitForSeconds(1f);
        gameObject.GetComponent<EnemyScript>().health += 300;
        yield return new WaitForSeconds(0.55f);
        if (transform.rotation.y == 0)
        {
            GameObject copy = (Instantiate(deadMushroom, transform.position + new Vector3(1.016f, -0.649f, 0), Quaternion.identity));
        }
        else
        {
            GameObject copy = (Instantiate(deadMushroom, transform.position + new Vector3(-1.016f, -0.649f, 0), Quaternion.identity));
        }
    }
}

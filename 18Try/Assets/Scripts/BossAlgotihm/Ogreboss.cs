using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ogreboss : MonoBehaviour
{
    public float timeUlt;
    public int damageUlt;
    public GameObject hitFloor;
    public Animator animator;
    public AudioSource Roar;
    public AudioSource hitSource;
    public AudioClip hitClip;
    public GameObject GM;
    void Start()
    {
        timeUlt = Random.Range(5f, 10f);
        animator = gameObject.GetComponent<Animator>();
        hitSource = GameObject.Find("/fx/hitfloorfx").GetComponent<AudioSource>();
        GM = GameObject.FindGameObjectWithTag("GameController");
        Roar = GameObject.Find("/fx/roarfx").GetComponent<AudioSource>();
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
            timeUlt = Random.Range(7.5f, 15f);
            StartCoroutine(Ulting());
        }
        if (gameObject.GetComponent<EnemyScript>().health <= 0)
        {
            if (GM.GetComponent<GameManager>()._playingTime <= 165f)
            {
                GM.GetComponent<GameManager>()._playingTime = 165f;
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
        animator.Play("enemy_6_anim_ult");
        yield return new WaitForSeconds(1.25f);
        if (hitSource != null)
        {
            hitSource.PlayOneShot(hitClip);
        }
        if (transform.rotation.y == 0)
        {
            GameObject copy = (Instantiate(hitFloor, transform.position + new Vector3(3f, 0, 0), Quaternion.identity));
        }
        else
        {
            GameObject copy = (Instantiate(hitFloor, transform.position + new Vector3(-3f, 0, 0), Quaternion.identity));
        }
    }
}

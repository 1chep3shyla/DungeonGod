using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallMoving : MonoBehaviour
{
    public Transform _target;
    public float speed;
    public GameObject player;

    void Start()
    {
        _target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
    }
    void Update()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        _target = GameObject.FindGameObjectWithTag("Enemy").GetComponent<Transform>();
        if (Time.timeScale == 1.0f)
        {
            transform.position = Vector2.MoveTowards(transform.position, _target.position, speed * Time.deltaTime);

        }


       
    }
    private void OnTriggerEnter2D(Collider2D enemy)
    {
        if (enemy.gameObject.tag == "Enemy")
        {
            enemy.gameObject.GetComponent<EnemyScript>().health -= (int)((float)player.GetComponent<FireBallScript>(). _damage* player.GetComponent<AddDamage>().addDMG + (float)player.GetComponent<FireBallScript>()._damage);
            Destroy(gameObject);
        }
    }
}

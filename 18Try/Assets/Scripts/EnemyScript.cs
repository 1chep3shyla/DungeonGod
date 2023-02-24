using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Vector2 positionObject;
    public Vector2 playerObject;
    Transform target;
    public float speed;
    public int damage;
    public int health;
    public GameObject player;
    public GameObject exPoint;
    public GameObject GM;
    public float timeAttack;
    public bool boss;

    
    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GameController");
        player = GameObject.FindGameObjectWithTag("Player");

    }

    // Update is called once per frame
    void Update()
    {
        timeAttack -= Time.deltaTime;
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
        playerObject = Vector2.MoveTowards(target.position, target.position, 0);
        positionObject = Vector2.MoveTowards(transform.position, transform.position, 0);
        if (positionObject.x >= playerObject.x)
        {
            gameObject.transform.rotation = Quaternion.Euler(new Vector2(0f, 180f));
        }
        else
        {
            gameObject.transform.rotation = Quaternion.Euler(new Vector2(0f, 0f));
        }
;
        if (GM.GetComponent<GameManager>()._gameIs == true && GM.GetComponent<GameManager>().pause == false && GM.GetComponent<GameManager>().SkillChoose.activeInHierarchy == false)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }

        if (health <= 0)
        {
            if (boss == false)
            {
                player.GetComponent<achievements>().achievement[0] += 1;
            }
            GameObject copy = (Instantiate(exPoint, transform.position, Quaternion.identity));
            copy.GetComponent<Experience>().expGive = 1;
            int random = Random.Range(0, 100);
            if (GM.GetComponent<GameManager>().bossIs[0] == false) {
                {
                    if (random < 30)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 1;
                        player.GetComponent<achievements>().achievement[3] += 1;
                    }
                    if (random >= 30 && random < 45)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 2;
                        player.GetComponent<achievements>().achievement[3] += 2;
                    }
                    if (random >= 45 && random < 55)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 3;
                        player.GetComponent<achievements>().achievement[3] += 3;
                    }
                }
            }
            if (GM.GetComponent<GameManager>().bossIs[0] == true && GM.GetComponent<GameManager>().bossIs[1] == false)
            {
                {
                    if (random < 30)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 2;
                        player.GetComponent<achievements>().achievement[3] += 2;
                    }
                    if (random >= 30 && random < 45)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 3;
                        player.GetComponent<achievements>().achievement[3] += 3;
                    }
                    if (random >= 45 && random < 55)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 4;
                        player.GetComponent<achievements>().achievement[3] += 4;
                    }
                }
            }
            if (GM.GetComponent<GameManager>().bossIs[1] == true && GM.GetComponent<GameManager>().bossIs[2] == false)
            {
                {
                    if (random < 30)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 3;
                        player.GetComponent<achievements>().achievement[3] += 3;
                    }
                    if (random >= 30 && random < 45)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 4;
                        player.GetComponent<achievements>().achievement[3] += 4;
                    }
                    if (random >= 45 && random < 55)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 5;
                        player.GetComponent<achievements>().achievement[3] += 5;
                    }
                }
            }
            if (GM.GetComponent<GameManager>().bossIs[2] == true)
            {
                {
                    if (random < 30)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 4;
                        player.GetComponent<achievements>().achievement[3] += 4;
                    }
                    if (random >= 30 && random < 45)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 5;
                        player.GetComponent<achievements>().achievement[3] += 5;
                    }
                    if (random >= 45 && random < 55)
                    {
                        player.GetComponent<PlayerStats>()._stats[3] += 6;
                        player.GetComponent<achievements>().achievement[3] += 6;
                    }
                }
            }
            player.GetComponent<PlayerStats>()._curStats[0] += player.GetComponent<Vampirizm>().hpReturn;
            if (boss == false)
            {
                Destroy(gameObject);
            }
        }
        if (GM.GetComponent<GameManager>()._gameIs == false)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionStay2D(Collision2D Player)
    {
        if (Player.gameObject.tag == "Player")
        {
            if (timeAttack <= 0f) 
            {
                if (Player.gameObject.GetComponent<Shield>().Working != true || Player.gameObject.GetComponent<Shield>().hpShield <= 0 )
                {
                    timeAttack = 0.3f;
                    Player.gameObject.GetComponent<PlayerStats>().Hitted();
                    Player.gameObject.GetComponent<PlayerStats>()._curStats[0] -= damage;
                }
                if (Player.gameObject.GetComponent<Shield>().hpShield > 0 )
                {
                    Player.gameObject.GetComponent<PlayerStats>().Hitted();
                    Player.gameObject.GetComponent<Shield>().hpShield -= damage;
                    timeAttack = 0.3f;
                }
            }
        }
    }
}

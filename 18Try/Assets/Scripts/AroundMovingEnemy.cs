using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundMovingEnemy : MonoBehaviour
{
    [SerializeField]
    public Transform center;

    [SerializeField]
    public float radius = 1f, angularSpeed = 2f;
    public float positionX, positionY, angle = 0f;
    private float TimeSpeed;
    public int damage;
    void Update()
    {
        if (center == null)
        {
            Destroy(gameObject);
        }
        else
        {
            positionX = center.position.x + Mathf.Cos(angle) * radius;
            positionY = center.position.y + Mathf.Sin(angle) * radius;
            transform.position = new Vector2(positionX, positionY);
            angle = angle + Time.deltaTime * angularSpeed;
        }

    }

    private void OnTriggerEnter2D(Collider2D player)
    {
        if (player.gameObject.tag == "Player")
        {
            player.gameObject.GetComponent<PlayerStats>()._curStats[0] -= damage;
            player.gameObject.GetComponent<PlayerStats>().Hitted();
            Destroy(gameObject);
        }
    }
}

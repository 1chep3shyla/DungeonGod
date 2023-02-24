using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AroundMoving : MonoBehaviour
{
    [SerializeField]
    Transform center;

    [SerializeField]
    float radius = 1f, angularSpeed = 2f;
    public float positionX, positionY, angle = 0f;
    private float TimeSpeed;

    void Start()
    {
        center = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    void Update()
    {

        positionX = center.position.x + Mathf.Cos(angle) * radius;
        positionY = center.position.y + Mathf.Sin(angle) * radius;
        transform.position = new Vector2(positionX, positionY);
        angle = angle + Time.deltaTime * angularSpeed;
    }
}

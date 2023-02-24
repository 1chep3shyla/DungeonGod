using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolemWave : MonoBehaviour
{
    public float posX;
    public float posY;
    
    void Update()
    {
        transform.localPosition = new Vector2(transform.localPosition.x + posX, transform.localPosition.y + posY);
    }
}

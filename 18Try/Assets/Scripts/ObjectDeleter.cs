using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDeleter : MonoBehaviour
{
    public GameObject GM;
    public bool can;

    void Start()
    {
        GM = GameObject.FindGameObjectWithTag("GameController");
    }
    void Update()
    {
        if (GM.GetComponent<GameManager>()._gameIs == false)
        {
            Destroy(gameObject);
        }
        if (can == true)
        {
            Destroy(gameObject, 0.5f);
        }
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathSpawner : MonoBehaviour
{

    public GameObject child;

    void Update()
    {
        if (gameObject.GetComponent<EnemyScript>().health <=0)
        {
            GameObject childOne = (Instantiate(child, transform.position + new Vector3(0.1f, 0, 0), Quaternion.identity));
            GameObject chieldTwo = (Instantiate(child, transform.position + new Vector3(-0.1f, 0, 0), Quaternion.identity));
        }
    }
}

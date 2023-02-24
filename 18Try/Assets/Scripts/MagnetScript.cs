using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MagnetScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerStay2D(Collider2D expi)
    {
        if (expi.gameObject.tag == "Exp")
        {
            expi.GetComponent<Experience>().speed = 5f;
        }
    }

    private void OnTriggerExit2D(Collider2D expirence)
    {
        if (expirence.gameObject.tag == "Exp")
        {
            expirence.GetComponent<Experience>().speed = 0f;
        }
    }
}

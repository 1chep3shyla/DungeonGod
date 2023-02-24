using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFolow : MonoBehaviour
{
    public Transform playerTrans;
    public bool thing;
    

    // Update is called once per frame
    void FixedUpdate()
    {
        if (thing == false)
        {
            transform.position = new Vector3(playerTrans.position.x, playerTrans.position.y, -100);
        }
        else
        {
            transform.position = new Vector3(playerTrans.position.x, playerTrans.position.y,0);
        }
    }
}

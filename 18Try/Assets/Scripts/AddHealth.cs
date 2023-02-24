using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddHealth : MonoBehaviour
{
    public int levelCur;
    public int levelPlay;
    public int costUpHealth;
    public Text[] UIHealth;

    void Update()
    {
        UIHealth[0].text = " " + gameObject.GetComponent<PlayerStats>()._stats[0];
        UIHealth[1].text = " " + gameObject.GetComponent<PlayerStats>()._stats[0];
        UIHealth[2].text = "Cost: " + costUpHealth;
        UIHealth[3].text = "Cost: " + costUpHealth;

    }
    public void buy()
    {
        if (gameObject.GetComponent<PlayerStats>()._stats[3] >= costUpHealth)
        {
            gameObject.GetComponent<PlayerStats>().UpSomething();
            gameObject.GetComponent<PlayerStats>()._stats[3] -= costUpHealth;
            levelCur++;
            gameObject.GetComponent<PlayerStats>()._stats[0] += 25;
            levelPlay = levelCur;
            if (levelCur < 10)
            {
                costUpHealth += 50;
            }
            if (levelCur >= 10 && levelCur < 20)
            {
                costUpHealth += 75;
            }
            if (levelCur >= 20 && levelCur < 30)
            {
                costUpHealth += 100;
            }
            if (levelCur >= 30 && levelCur < 40)
            {
                costUpHealth += 200;
            }
            if (levelCur >= 40 && levelCur < 50)
            {
                costUpHealth += 275;
            }
            if (levelCur >= 50)
            {
                costUpHealth += 350;
            }
        }
    }
}

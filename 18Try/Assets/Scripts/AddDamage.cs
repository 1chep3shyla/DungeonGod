using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddDamage : MonoBehaviour
{
    public float addDMG;
    public int levelCur;
    public int levelPlay;
    public int costUp;
    public Text[] UIDamage;

    void Update()
    {
        addDMG = (0.1f * levelPlay);
        UIDamage[0].text = " " + 0.1 * levelCur;
        UIDamage[1].text = " " + 0.1 * levelCur;
        UIDamage[2].text = "Cost: " + costUp;
        UIDamage[3].text = "Cost: " + costUp;

    }   
    public void buy()
    {
        if (gameObject.GetComponent<PlayerStats>()._stats[3] >= costUp)
        {
            gameObject.GetComponent<PlayerStats>().UpSomething();
            gameObject.GetComponent<PlayerStats>()._stats[3] -= costUp;
            levelCur++;
            levelPlay = levelCur;
            if (levelCur < 10)
            {
                costUp += 50;
            }
            if (levelCur >= 10 && levelCur < 20)
            {
                costUp += 75;
            }
            if (levelCur >= 20 && levelCur < 30)
            {
                costUp += 100;
            }
            if (levelCur >= 30 && levelCur < 40)
            {
                costUp += 200;
            }
            if (levelCur >= 40 && levelCur < 50)
            {
                costUp += 275;
            }
            if (levelCur >= 50)
            {
                costUp += 350;
            }
        }
    }
}

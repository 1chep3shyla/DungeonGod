using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class achievements : MonoBehaviour
{
    public int[] achievement;
    public Text[] achievementsText;// 0 = killing Monsters;  2 = killing Bosses; 4 = Deaths; 6 = EarnedMoney;

    void Update()
    {
        achievementsText[0].text = " " + achievement[0];
        achievementsText[1].text = " " + achievement[0];
        achievementsText[2].text = " " + achievement[1];
        achievementsText[3].text = " " + achievement[1];
        achievementsText[4].text = " " + achievement[2];
        achievementsText[5].text = " " + achievement[2];
        achievementsText[6].text = " " + achievement[3];
        achievementsText[7].text = " " + achievement[3];
    }
}

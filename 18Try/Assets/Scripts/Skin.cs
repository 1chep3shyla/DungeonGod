using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Skin : MonoBehaviour
{
    public int Cost;
    public bool buy;
    public GameObject onBut;
    public GameObject BuyBut;
    public Text Name;
    public Text NameTwo;
    public string nameString;
    public Text costText;
    public PlayerStats player;

    public void BuyIt()
    {
        if (player._stats[3] >= Cost && buy == false)
        {
            player._stats[3] -= Cost;

            onBut.SetActive(true);
            BuyBut.SetActive(false);
            buy = true;
        }
        
    }
    public void Choose()
    {
        Name.text = " " + nameString;
        NameTwo.text = " " + nameString;
        if (buy == false)
        {
            BuyBut.SetActive(true);
        }
        else
        {
            onBut.SetActive(true);
        }
    }
    void Update()
    {
        if (costText != null)
        {
            costText.text = " " + Cost;
        }
    }
}

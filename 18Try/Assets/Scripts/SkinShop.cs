using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinShop : MonoBehaviour
{
    public GameObject player;
    public Skin Default;
    public Skin[] SkinsAll;

    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }
    public void WomenBuy()
    {
        SkinsAll[1].BuyIt();
    }
    public void RedBuy()
    {
        SkinsAll[2].BuyIt();
    }
    public void GreenBuy()
    {
        SkinsAll[3].BuyIt();
    }
    public void PigBuy()
    {
        SkinsAll[4].BuyIt();
    }
    public void SlimeBuy()
    {
        SkinsAll[5].BuyIt();
    }
    public void WhiteBuy()
    {
        SkinsAll[6].BuyIt();
    }
    public void GrayBuy()
    {
        SkinsAll[7].BuyIt();
    }
    public void NecroBuy()
    {
        SkinsAll[8].BuyIt();
    }
    public void RainbowBuy()
    {
        SkinsAll[9].BuyIt();
    }
    public void BlackBuy()
    {
        SkinsAll[10].BuyIt();
    }
    public void SkullBuy()
    {
        SkinsAll[11].BuyIt();
    }
    public void SkinheadBuy()
    {
        SkinsAll[12].BuyIt();
    }
    public void CBBuy()
    {
        SkinsAll[13].BuyIt();
    }
    public void IllBuy()
    {
        SkinsAll[14].BuyIt();
    }
    public void ChooseAny()
    {
        SkinsAll[0].onBut.SetActive(false);
        SkinsAll[0].BuyBut.SetActive(false);

        SkinsAll[1].onBut.SetActive(false);
        SkinsAll[1].BuyBut.SetActive(false);

        SkinsAll[2].onBut.SetActive(false);
        SkinsAll[2].BuyBut.SetActive(false);

        SkinsAll[3].onBut.SetActive(false);
        SkinsAll[3].BuyBut.SetActive(false);

        SkinsAll[4].onBut.SetActive(false);
        SkinsAll[4].BuyBut.SetActive(false);

        SkinsAll[5].onBut.SetActive(false);
        SkinsAll[5].BuyBut.SetActive(false);

        SkinsAll[6].onBut.SetActive(false);
        SkinsAll[6].BuyBut.SetActive(false);

        SkinsAll[7].onBut.SetActive(false);
        SkinsAll[7].BuyBut.SetActive(false);

        SkinsAll[8].onBut.SetActive(false);
        SkinsAll[8].BuyBut.SetActive(false);

        SkinsAll[9].onBut.SetActive(false);
        SkinsAll[9].BuyBut.SetActive(false);

        SkinsAll[10].onBut.SetActive(false);
        SkinsAll[10].BuyBut.SetActive(false);

        SkinsAll[11].onBut.SetActive(false);
        SkinsAll[11].BuyBut.SetActive(false);

        SkinsAll[12].onBut.SetActive(false);
        SkinsAll[12].BuyBut.SetActive(false);

        SkinsAll[13].onBut.SetActive(false);
        SkinsAll[13].BuyBut.SetActive(false);

        SkinsAll[14].onBut.SetActive(false);
        SkinsAll[14].BuyBut.SetActive(false);

    }


}


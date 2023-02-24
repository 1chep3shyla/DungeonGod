using System.Collections;
using System.Collections.Generic;
using UnityEngine;



[System.Serializable]
public class PlayerData
{
    public bool[] whichSkinOn = new bool [15];
    public int[] costUpSave = new int[2]; // 0 - dmg ; 1 - hp
    public bool[] WhichBuy = new bool[15];
    public int KillingMonsters;
    public int Money;
    public int MaxHP;
    public int KilingBosses;
    public int Deaths;
    public int Earned;
    public int levelHP;
    public int levelDMG;
    public bool[] joystickWhich = new bool[3];


    public PlayerData(PlayerStats player)
    { 

        Money = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>()._stats[3];
        MaxHP = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerStats>()._stats[0];
        KillingMonsters = GameObject.FindGameObjectWithTag("Player").GetComponent<achievements>().achievement[0];
        KilingBosses = GameObject.FindGameObjectWithTag("Player").GetComponent<achievements>().achievement[1];
        Deaths = GameObject.FindGameObjectWithTag("Player").GetComponent<achievements>().achievement[2];
        Earned = GameObject.FindGameObjectWithTag("Player").GetComponent<achievements>().achievement[3];
        levelDMG = GameObject.FindGameObjectWithTag("Player").GetComponent<AddDamage>().levelCur;
        levelHP = GameObject.FindGameObjectWithTag("Player").GetComponent<AddHealth>().levelCur;
        costUpSave[0] = GameObject.FindGameObjectWithTag("Player").GetComponent<AddDamage>().costUp;    
        costUpSave[1] = GameObject.FindGameObjectWithTag("Player").GetComponent<AddHealth>().costUpHealth;
        for (int j = 0; j < GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoving>().JoysticksAll.Length; j++)
        {
            joystickWhich[j] = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerMoving>().JoysticksAll[j].activeSelf;
        }
        for (int i = 0; i < whichSkinOn.Length; i++)
        {
            whichSkinOn[i] = GameObject.FindGameObjectWithTag("Player").GetComponent<PlayerSkins>().whichOn[i];
        }
        for (int a = 0; a < WhichBuy.Length; a++)
        {
            WhichBuy[a] = GameObject.FindGameObjectWithTag("Player").GetComponent<SkinShop>().SkinsAll[a].buy;
        }

    }
}

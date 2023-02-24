using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shield : MonoBehaviour
{
    public Slider shieldSlider;
    public GameObject player;
    public int hpShield;
    public int hpShieldMax;
    public float timeAppear;
    public float curTime;
    public bool Working;
    public Animator shileded;
    public ParticleSystem destroyed;
    public bool played;

    public AudioSource shieldSourceDestroyFx;
    public AudioClip shieldDestroyFx;

    public AudioSource shieldSourceFx;
    public AudioClip shieldFx;
    void Update()
    {

        shieldSlider.maxValue = hpShieldMax;
        shieldSlider.value = hpShield;
        if (hpShield <= 0 && played == false && player.GetComponent<PlayerStats>()._passiveSpellLevel[1] > 0)
        {
            destroyed.Play();
            shieldSourceDestroyFx.PlayOneShot(shieldDestroyFx);
            played = true;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 0)
        {
            hpShieldMax = 0;
            timeAppear = 5f;
            curTime = 0f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 1)
        {
            hpShieldMax = 20;
            timeAppear = 5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 3)
        {
            hpShieldMax = 30;
            timeAppear = 5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 4)
        {
            hpShieldMax = 40;
            timeAppear = 5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 5)
        {
            hpShieldMax = 50;
            timeAppear = 5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 6)
        {
            hpShieldMax = 70;
            timeAppear = 5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 7)
        {
            hpShieldMax = 90;
            timeAppear = 5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 8)
        {
            hpShieldMax = 110;
            timeAppear = 4.5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 9)
        {
            hpShieldMax = 130;
            timeAppear = 4.5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 10)
        {
            hpShieldMax = 150;
            timeAppear = 4.5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 11)
        {
            hpShieldMax = 180;
            timeAppear = 4f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 12)
        {
            hpShieldMax = 210;
            timeAppear = 4f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 13)
        {
            hpShieldMax = 240;
            timeAppear = 4f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 14)
        {
            hpShieldMax = 270;
            timeAppear = 3.5f;
        }
        if (player.GetComponent<PlayerStats>()._passiveSpellLevel[1] == 15)
        {
            hpShieldMax = 400;
            timeAppear = 3f;
        }
        if (Working == true)
        {
            curTime -= Time.deltaTime;
            if (curTime <= 0f)
            {
                
                curTime = timeAppear;
                hpShield = hpShieldMax;
                shileded.Play("shield_anim");
                shieldSourceFx.PlayOneShot(shieldFx);
                played = false;
            }
        }

    }
}

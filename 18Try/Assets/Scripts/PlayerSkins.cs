using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSkins : MonoBehaviour
{
    public bool[] whichOn;
    private string curAnimation;
    public Animator animator;
    public Sprite[] hpBar;
    public GameObject[] sliders;
    public bool workingBar;
    public GameObject player;
    public bool shop;
    // Update is called once per frame
    void Start()
    {
        animator = GetComponent<Animator>();
        player = GameObject.FindGameObjectWithTag("Player");
    }
    void Update()
    {
        if (shop == false)
        {
            if (player.GetComponent<PlayerSkins>().whichOn[0] == true)
            {
                animator.Play("player_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[0];
                    sliders[1].GetComponent<Image>().sprite = hpBar[0];
                }

            }
            if (player.GetComponent<PlayerSkins>().whichOn[1] == true)
            {
                animator.Play("player_red_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[2];
                    sliders[1].GetComponent<Image>().sprite = hpBar[2];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[2] == true)
            {
                animator.Play("player_green_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[1];
                    sliders[1].GetComponent<Image>().sprite = hpBar[1];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[3] == true)
            {
                animator.Play("player_gray_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[5];
                    sliders[1].GetComponent<Image>().sprite = hpBar[5];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[4] == true)
            {
                animator.Play("player_white_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[6];
                    sliders[1].GetComponent<Image>().sprite = hpBar[6];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[5] == true)
            {
                animator.Play("player_black_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[7];
                    sliders[1].GetComponent<Image>().sprite = hpBar[7];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[6] == true)
            {
                animator.Play("player_rainbow_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[8];
                    sliders[1].GetComponent<Image>().sprite = hpBar[8];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[7] == true)
            {
                animator.Play("player_slime_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[4];
                    sliders[1].GetComponent<Image>().sprite = hpBar[4];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[8] == true)
            {
                animator.Play("player_skull_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[3];
                    sliders[1].GetComponent<Image>().sprite = hpBar[3];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[9] == true)
            {
                animator.Play("player_pig_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[9];
                    sliders[1].GetComponent<Image>().sprite = hpBar[9];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[10] == true)
            {
                animator.Play("player_necr_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[10];
                    sliders[1].GetComponent<Image>().sprite = hpBar[10];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[11] == true)
            {
                ChangeAnimation("player_women_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[0];
                    sliders[1].GetComponent<Image>().sprite = hpBar[0];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[12] == true)
            {
                ChangeAnimation("player_skinhead_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[11];
                    sliders[1].GetComponent<Image>().sprite = hpBar[11];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[13] == true)
            {
                ChangeAnimation("player_cb_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[12];
                    sliders[1].GetComponent<Image>().sprite = hpBar[12];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[14] == true)
            {
                ChangeAnimation("player_ill_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[13];
                    sliders[1].GetComponent<Image>().sprite = hpBar[13];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[15] == true)
            {
                ChangeAnimation("player_darkBlue_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[14];
                    sliders[1].GetComponent<Image>().sprite = hpBar[14];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[16] == true)
            {
                ChangeAnimation("player_pink_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[15];
                    sliders[1].GetComponent<Image>().sprite = hpBar[15];
                }
            }
            if (player.GetComponent<PlayerSkins>().whichOn[17] == true)
            {
                ChangeAnimation("player_no_anim");
                if (workingBar == true)
                {
                    sliders[0].GetComponent<Image>().sprite = hpBar[16];
                    sliders[1].GetComponent<Image>().sprite = hpBar[16];
                }
            }
        }


    }

    void ChangeAnimation(string animation)
    {
        animator.Play(animation);
        curAnimation = animation;
    }
    public void NoPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[17] = true;
        ChangeAnimation("player_no_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[16];
            sliders[1].GetComponent<Image>().sprite = hpBar[16];
        }
    }
    public void PinkPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[16] = true;
        ChangeAnimation("player_pink_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[15];
            sliders[1].GetComponent<Image>().sprite = hpBar[15];
        }
    }
    public void DarkBluePlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[15] = true;
        ChangeAnimation("player_darkBlue_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[14];
            sliders[1].GetComponent<Image>().sprite = hpBar[14];

        }
    }
    public void SkinheadPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[12] = true;
        ChangeAnimation("player_skinhead_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[11];
            sliders[1].GetComponent<Image>().sprite = hpBar[11];
        }
    }
    public void CbPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[13] = true;
        ChangeAnimation("player_cb_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[12];
            sliders[1].GetComponent<Image>().sprite = hpBar[12];
        }
    }
    public void IllPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[14] = true;
        ChangeAnimation("player_ill_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[13];
            sliders[1].GetComponent<Image>().sprite = hpBar[13];
        }
    }
    public void BluePlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[0] = true;
        ChangeAnimation("player_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[0];
            sliders[1].GetComponent<Image>().sprite = hpBar[0];
        }
    }
    public void RedPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[1] = true;
        ChangeAnimation("player_red_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[2];
            sliders[1].GetComponent<Image>().sprite = hpBar[2];
        }
    }
    public void GreenPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[2] = true;
        ChangeAnimation("player_green_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[1];
            sliders[1].GetComponent<Image>().sprite = hpBar[1];
        }
    }
    public void GrayPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[3] = true;
        ChangeAnimation("player_gray_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[5];
            sliders[1].GetComponent<Image>().sprite = hpBar[5];
        }
    }
    public void WhitePlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[4] = true;
        ChangeAnimation("player_white_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[6];
            sliders[1].GetComponent<Image>().sprite = hpBar[6];
        }
    }

    public void BlackPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[5] = true;
        ChangeAnimation("player_black_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[7];
            sliders[1].GetComponent<Image>().sprite = hpBar[7];
        }
    }
    public void RainbowPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[6] = true;
        ChangeAnimation("player_rainbow_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[8];
            sliders[1].GetComponent<Image>().sprite = hpBar[8];
        }
    }


    public void SlimePlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[7] = true;
        ChangeAnimation("player_slime_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[4];
            sliders[1].GetComponent<Image>().sprite = hpBar[4];
        }
    }
    public void SkullPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[8] = true;
        ChangeAnimation("player_skull_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[3];
            sliders[1].GetComponent<Image>().sprite = hpBar[3];
        }
    }
    public void PigPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[9] = true;
        ChangeAnimation("player_pig_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[9];
            sliders[1].GetComponent<Image>().sprite = hpBar[9];
        }
    }
    public void NecrPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[10] = true;
        ChangeAnimation("player_necr_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[10];
            sliders[1].GetComponent<Image>().sprite = hpBar[10];
        }
    }
    public void WomenPlayer()
    {
        for (int i = 0; i < whichOn.Length; i++)
        {
            whichOn[i] = false;
        }
        whichOn[11] = true;
        ChangeAnimation("player_women_anim");
        if (workingBar == true)
        {
            sliders[0].GetComponent<Image>().sprite = hpBar[0];
            sliders[1].GetComponent<Image>().sprite = hpBar[0];
        }
    }
    public void ShopIs()
    {
        shop = true;

        if (player.GetComponent<PlayerSkins>().whichOn[0] == true)
        {
            animator.Play("player_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[0];
                sliders[1].GetComponent<Image>().sprite = hpBar[0];
            }

        }
        if (player.GetComponent<PlayerSkins>().whichOn[1] == true)
        {
            animator.Play("player_red_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[2];
                sliders[1].GetComponent<Image>().sprite = hpBar[2];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[2] == true)
        {
            animator.Play("player_green_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[1];
                sliders[1].GetComponent<Image>().sprite = hpBar[1];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[3] == true)
        {
            animator.Play("player_gray_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[5];
                sliders[1].GetComponent<Image>().sprite = hpBar[5];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[4] == true)
        {
            animator.Play("player_white_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[6];
                sliders[1].GetComponent<Image>().sprite = hpBar[6];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[5] == true)
        {
            animator.Play("player_black_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[7];
                sliders[1].GetComponent<Image>().sprite = hpBar[7];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[6] == true)
        {
            animator.Play("player_rainbow_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[8];
                sliders[1].GetComponent<Image>().sprite = hpBar[8];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[7] == true)
        {
            animator.Play("player_slime_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[4];
                sliders[1].GetComponent<Image>().sprite = hpBar[4];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[8] == true)
        {
            animator.Play("player_skull_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[3];
                sliders[1].GetComponent<Image>().sprite = hpBar[3];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[9] == true)
        {
            animator.Play("player_pig_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[9];
                sliders[1].GetComponent<Image>().sprite = hpBar[9];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[10] == true)
        {
            animator.Play("player_necr_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[10];
                sliders[1].GetComponent<Image>().sprite = hpBar[10];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[11] == true)
        {
            ChangeAnimation("player_women_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[0];
                sliders[1].GetComponent<Image>().sprite = hpBar[0];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[12] == true)
        {
            animator.Play("player_skinhead_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[11];
                sliders[1].GetComponent<Image>().sprite = hpBar[11];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[13] == true)
        {
            animator.Play("player_cb_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[12];
                sliders[1].GetComponent<Image>().sprite = hpBar[12];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[14] == true)
        {
            ChangeAnimation("player_ill_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[13];
                sliders[1].GetComponent<Image>().sprite = hpBar[13];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[15] == true)
        {
            animator.Play("player_darkBlue_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[14];
                sliders[1].GetComponent<Image>().sprite = hpBar[14];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[16] == true)
        {
            animator.Play("player_pink_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[15];
                sliders[1].GetComponent<Image>().sprite = hpBar[15];
            }
        }
        if (player.GetComponent<PlayerSkins>().whichOn[17] == true)
        {
            ChangeAnimation("player_no_anim");
            if (workingBar == true)
            {
                sliders[0].GetComponent<Image>().sprite = hpBar[16];
                sliders[1].GetComponent<Image>().sprite = hpBar[16];
            }
        }

    }
    public void ShopOff()
    {
        shop = false;
    }



}


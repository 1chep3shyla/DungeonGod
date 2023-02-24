    using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerStats : MonoBehaviour
{
    [Header("Stats")]
    public int[] _stats; // 0 - HP, 1 = EXP, 3 = Gold, 4 = Level
    public int[] _curStats; // 0 = CurHealth, 1 = CurExp
    public int[] _spellsLevel; // 0 = DieAura, 1 = Clamp , 2 = three points , 3 = fireball, 4 = fireClamp
    public int[] _passiveSpellLevel; // 0 = Health Regen, 1 = DamageReduce, 2 = MoreGold, 3 = More Damage, 5 = MoreExp, 4 = speed, vampirizm =6
    public bool addAchi;

    [Header("UI")]
    public Sprite[] _chooseSprites;
    public GameObject[] _isSprites = new GameObject[8];
    public Slider[] _sliders; // 0 = exp, 1 = hp
    public GameObject player;
    public GameObject[] _spellGO;
    public Slider[] sliders;
    public Text[] goldText;
    public GameObject losePanel;
    public Sprite defaultSprite;
    public Text[] adMinMax;

    [Header("Music")]
    public GameObject[] sounds;
    public AudioSource hit;
    public AudioClip hitFX;
    public AudioClip levelUpFx;
    public AudioSource levelUpSource;


    public GameObject GM;
    public float timeSave;
    public bool firstTime;
    public int deathCount;
    public int restartCount;
    public InterstitialAds ads;
    public int levelUpAdd;
    public int minAdd;
    public int maxAdd;

    public RewardedAds add;
    void Start()
    {
        LoadPlayer();
        minAdd = Random.Range(levelUpAdd * 50, levelUpAdd * 60);
        maxAdd = Random.Range(levelUpAdd * 100, levelUpAdd * 110);
        add.LoadAd();
    }

    void Update()
    {
        if (gameObject.GetComponent<AddDamage>().levelCur + gameObject.GetComponent<AddHealth>().levelCur == 0)
        {
            levelUpAdd = gameObject.GetComponent<AddDamage>().levelCur + gameObject.GetComponent<AddHealth>().levelCur;
        }
        else
        {
            levelUpAdd = 1;
        }
        adMinMax[0].text = " " + minAdd + "-" + maxAdd;
        adMinMax[1].text = " " + minAdd + "-" + maxAdd;

        _sliders[0].maxValue = _stats[1];
        _sliders[0].value = _curStats[1];

        _sliders[1].maxValue = _stats[0];
        _sliders[1].value = _curStats[0];

        goldText[0].text = " " + _stats[3];
        goldText[1].text = " " + _stats[3];

        if (_spellsLevel[0] == 0)
        {
            _spellGO[0].SetActive(false);
        }
        if (_curStats[0] <= 0)
        {
            losePanel.SetActive(true);
            sounds[0].SetActive(true);
            sounds[1].SetActive(false);
            Time.timeScale = 0f;
            if (addAchi == false)
            {
                gameObject.GetComponent<achievements>().achievement[2] += 1;
                deathCount++;
                addAchi = true;
            }
        }
        else
        {
            sounds[0].SetActive(false);
        }
        timeSave -= Time.deltaTime;
        if (timeSave <= 0f)
        {
            SavePlayer();
            timeSave = 0.15f;
        }
    }

        public void StartGame()
        {
        player.GetComponent<GivingSpells>().first = true;
        GM.GetComponent<GameManager>()._gameIs = true;
        GM.GetComponent<GameManager>().pause = false;
        GM.GetComponent<GameManager>()._playingTime = 0f;
        addAchi = false;
        for (var boss = 0; boss < GM.GetComponent<GameManager>().bossIs.Length; boss++)
        {
            GM.GetComponent<GameManager>().bossIs[boss] = false;
        }
        transform.localPosition = new Vector2(0, 0);
        _curStats[0] = _stats[0];
        _stats[1] = 10;
        _curStats[1] = 10;
        for (int i = 0; i < _spellsLevel.Length; i++)
        {
            _spellsLevel[i] = 0;
        }
        for (int a = 0; a < _passiveSpellLevel.Length; a++)
        {
            _passiveSpellLevel[a] = 0;
        }
        for (int g = 0; g < _isSprites.Length; g++)
        {
            _isSprites[g].GetComponent<Image>().sprite = defaultSprite;
        } 
        for (int sp = 0; sp < _spellGO.Length; sp++)
        {
            _spellGO[sp].SetActive(false);
        }
        for (int sl = 0; sl < sliders.Length; sl++)
        {
            sliders[sl].value = 0;
        }
        player.GetComponent<WaterCuller>().coldown = null;
        player.GetComponent<Shield>().Working = false;
        player.GetComponent<FireBallScript>().coldown = null;
        player.GetComponent<AddDamage>().levelPlay = player.GetComponent<AddDamage>().levelCur;

    }
    public void RestartGame()
    {
        player.GetComponent<GivingSpells>().first = true;
        GM.GetComponent<GameManager>()._playingTime = 0f;
        addAchi = false;
        transform.localPosition = new Vector2(0, 0);
        _curStats[0] = _stats[0];
        _stats[1] = 10;
        _curStats[1] = 10;
        for (int i = 0; i < _spellsLevel.Length; i++)
        {
            _spellsLevel[i] = 0;
        }
        for (int a = 0; a < _passiveSpellLevel.Length; a++)
        {
            _passiveSpellLevel[a] = 0;
        }
        for (int g = 0; g < _isSprites.Length; g++)
        {
            _isSprites[g].GetComponent<Image>().sprite = defaultSprite;
        }
        for (int sp = 0; sp > _spellGO.Length; sp++)
        {
            _spellGO[sp].SetActive(false);
        }
        for (int sl = 0; sl < sliders.Length; sl++)
        {
            sliders[sl].value = 0;
        }
        player.GetComponent<WaterCuller>().coldown = null;
        player.GetComponent<Shield>().Working = false;
        player.GetComponent<FireBallScript>().coldown = null;
        player.GetComponent<AddDamage>().levelPlay = player.GetComponent<AddDamage>().levelCur;

    }

    public void choosingSlotOne()
    {
        bool kek = false;
        GM.GetComponent<GameManager>()._gameIs = true;
        for (int i = 0; kek == false; i++)
        {
            if (_isSprites[i].GetComponent<Image>().sprite == player.GetComponent<GivingSpells>()._slot[0].GetComponent<Image>().sprite)
            {
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[0]) //speed
                {
                    if (_passiveSpellLevel[4] < 15)
                    {
                        _passiveSpellLevel[4] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[1]) // damagereduce
                {
                    if (_passiveSpellLevel[1] < 15)
                    {
                        _passiveSpellLevel[1] += 1;
                        player.GetComponent<Shield>().Working = true;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[2]) // damage
                {
                    if (_passiveSpellLevel[3] < 15)
                    {
                        _passiveSpellLevel[3] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                        player.GetComponent<AddDamage>().levelPlay++;
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[3]) //Health heal
                {
                    if (_passiveSpellLevel[0] < 15)
                    {
                        _passiveSpellLevel[0] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[4]) // die aura
                {
                    _spellsLevel[0] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    _spellGO[0].SetActive(true);

                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[5]) // fire ball
                {
                    _spellsLevel[3] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<FireBallScript>().Working = true;
                    
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[6]) // fireclamp
                {
                    _spellsLevel[4] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[7]) // waterball
                {
                    _spellsLevel[5] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[8]) // WaterCuller
                {
                    _spellsLevel[6] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<WaterCuller>().Working = true;
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[9]) // vampirizm
                {
                    if (_passiveSpellLevel[6] < 15)
                    {
                        _passiveSpellLevel[6] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[10]) // rain
                {
                    _spellsLevel[1] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[11]) // bomb
                {
                    _spellsLevel[2] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }

                kek = true;
            }
            if (_isSprites[i].GetComponent<Image>().sprite == defaultSprite)
            {
                _isSprites[i].GetComponent<Image>().sprite = player.GetComponent<GivingSpells>()._slot[0].GetComponent<Image>().sprite;
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[0]) //speed
                {
                    if (_passiveSpellLevel[4] < 15)
                    {
                        _passiveSpellLevel[4] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[1]) // damagereduce
                {
                    if (_passiveSpellLevel[1] < 15)
                    {
                        _passiveSpellLevel[1] += 1;
                        player.GetComponent<Shield>().Working = true;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[2]) // damage
                {
                    if (_passiveSpellLevel[3] < 15)
                    {
                        _passiveSpellLevel[3] += 1;
                        player.GetComponent<AddDamage>().levelPlay++;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[3]) //Health heal
                {
                    if (_passiveSpellLevel[0] < 15)
                    {
                        _passiveSpellLevel[0] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[4]) // die aura
                {
                    _spellsLevel[0] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    _spellGO[0].SetActive(true);

                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[5]) // fireball
                {
                    _spellsLevel[3] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<FireBallScript>().Working = true;
                    player.GetComponent<FireBallScript>().spellIcon = _isSprites[i];
                    player.GetComponent<FireBallScript>().coldown = sliders[i];
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[6]) // fireclamp
                {
                    _spellsLevel[4] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    _spellGO[1].SetActive(true);
                    _spellGO[1].GetComponent<FireClamp>().workingClamp = true;
                    _spellGO[1].GetComponent<FireClamp>().spellIcon = _isSprites[i];
                    _spellGO[1].GetComponent<FireClamp>().coldownClamp = sliders[i];

                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[7]) // waterball
                {
                    _spellsLevel[5] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[8]) // waterculler
                {
                    _spellsLevel[6] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<WaterCuller>().Working = true;
                    player.GetComponent<WaterCuller>().spellIcon = _isSprites[i];
                    player.GetComponent<WaterCuller>().coldown = sliders[i];

                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[9]) // vampirizm
                {
                    if (_passiveSpellLevel[6] < 15)
                    {
                        _passiveSpellLevel[6] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[10]) // rain
                {
                    _spellsLevel[1] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<StarFailingWorking>().spellIcon = _isSprites[i];
                    player.GetComponent<StarFailingWorking>().coldown = sliders[i];
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[11]) // bomb
                {
                    _spellsLevel[2] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<FireBombSpawner>().spellIcon = _isSprites[i];
                    player.GetComponent<FireBombSpawner>().coldown = sliders[i];
                }
                player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                kek = true;
            }
        }
        Time.timeScale = 1f;
    }
    public void choosingSlotTwo()
    {
        bool kek = false;
        GM.GetComponent<GameManager>()._gameIs = true;
        for (int i = 0; kek == false; i++)
        {
            if (_isSprites[i].GetComponent<Image>().sprite == player.GetComponent<GivingSpells>()._slot[1].GetComponent<Image>().sprite)
            {
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[0]) //speed
                {
                    if (_passiveSpellLevel[4] < 15)
                    {
                        _passiveSpellLevel[4] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[1]) // damagereduce
                {
                    if (_passiveSpellLevel[1] < 15)
                    {
                        _passiveSpellLevel[1] += 1;
                        player.GetComponent<Shield>().Working = true;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[2]) // damage
                {
                    if (_passiveSpellLevel[3] < 15)
                    {
                        _passiveSpellLevel[3] += 1;
                        player.GetComponent<AddDamage>().levelPlay++;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[3]) //Health heal
                {
                    if (_passiveSpellLevel[0] < 15)
                    {
                        _passiveSpellLevel[0] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[4]) // die aura
                {
                    _spellsLevel[0] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    _spellGO[0].SetActive(true);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[5]) // die aura
                {
                    _spellsLevel[3] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<FireBallScript>().Working = true;
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[6]) // fireclamp
                {
                    _spellsLevel[4] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[7]) // waterball
                {
                    _spellsLevel[5] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[8]) // WaterCuller
                {
                    _spellsLevel[6] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<WaterCuller>().Working = true;
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[9]) // vampirizm
                {
                    if (_passiveSpellLevel[6] < 15)
                    {
                        _passiveSpellLevel[6] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[10]) // rain
                {
                    _spellsLevel[1] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[11]) // bomb
                {
                    _spellsLevel[2] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                kek = true;
            }
            if (_isSprites[i].GetComponent<Image>().sprite == defaultSprite)
            {
                _isSprites[i].GetComponent<Image>().sprite = player.GetComponent<GivingSpells>()._slot[1].GetComponent<Image>().sprite;
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[0]) //speed
                {
                    if (_passiveSpellLevel[4] < 15)
                    {
                        _passiveSpellLevel[4] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[1]) // damagereduce
                {
                    if (_passiveSpellLevel[1] < 15)
                    {
                        _passiveSpellLevel[1] += 1;
                        player.GetComponent<Shield>().Working = true;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[2]) // damage
                {
                    if (_passiveSpellLevel[3] < 15)
                    {
                        _passiveSpellLevel[3] += 1;
                        player.GetComponent<AddDamage>().levelPlay++;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[3]) //Health heal
                {
                    if (_passiveSpellLevel[0] < 15)
                    {
                        _passiveSpellLevel[0] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[4]) // die aura
                {
                    _spellsLevel[0] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    _spellGO[0].SetActive(true);

                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[5]) // fireball
                {
                    _spellsLevel[3] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<FireBallScript>().Working = true;
                    player.GetComponent<FireBallScript>().spellIcon = _isSprites[i];
                    player.GetComponent<FireBallScript>().coldown = sliders[i];
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[6]) // fireclamp
                {
                    _spellsLevel[4] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    _spellGO[1].GetComponent<FireClamp>().workingClamp = true;
                    _spellGO[1].SetActive(true);
                    _spellGO[1].GetComponent<FireClamp>().spellIcon = _isSprites[i];
                    _spellGO[1].GetComponent<FireClamp>().coldownClamp = sliders[i];

                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[7]) // waterball
                {
                    _spellsLevel[5] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[8]) // waterculler
                {
                    _spellsLevel[6] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<WaterCuller>().Working = true;
                    player.GetComponent<WaterCuller>().spellIcon = _isSprites[i];
                    player.GetComponent<WaterCuller>().coldown = sliders[i];

                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[9]) // vampirizm
                {
                    if (_passiveSpellLevel[6] < 15)
                    {
                        _passiveSpellLevel[6] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[10]) // rain
                {
                    _spellsLevel[1] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<StarFailingWorking>().spellIcon = _isSprites[i];
                    player.GetComponent<StarFailingWorking>().coldown = sliders[i];
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[11]) // bomb
                {
                    _spellsLevel[2] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<FireBombSpawner>().spellIcon = _isSprites[i];
                    player.GetComponent<FireBombSpawner>().coldown = sliders[i];
                }
                player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                kek = true;
            }
        }
        Time.timeScale = 1f;
    }
    public void choosingSlotThree()
    {
        bool kek = false;
        GM.GetComponent<GameManager>()._gameIs = true;
        for (int i = 0; kek == false; i++)
        {
            if (_isSprites[i].GetComponent<Image>().sprite == player.GetComponent<GivingSpells>()._slot[2].GetComponent<Image>().sprite)
            {
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[0]) //speed
                {
                    if (_passiveSpellLevel[4] < 15)
                    {
                        _passiveSpellLevel[4] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[1]) // damagereduce
                {
                    if (_passiveSpellLevel[1] < 15)
                    {
                        _passiveSpellLevel[1] += 1;
                        player.GetComponent<Shield>().Working = true;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[2]) // damage
                {
                    if (_passiveSpellLevel[3] < 15)
                    {
                        _passiveSpellLevel[3] += 1;
                        player.GetComponent<AddDamage>().levelPlay++;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[3]) //Health heal
                {
                    if (_passiveSpellLevel[0] < 15)
                    {
                        _passiveSpellLevel[0] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[4]) // die aura
                {
                    _spellsLevel[0] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    _spellGO[0].SetActive(true);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[5]) // fireball
                {
                    _spellsLevel[3] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<FireBallScript>().Working = true;
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[6]) // fireclamp
                {
                    _spellsLevel[4] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[7]) // waterball
                {
                    _spellsLevel[5] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[8]) // WaterCuller
                {
                    _spellsLevel[6] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<WaterCuller>().Working = true;
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[9]) // vampirizm
                {
                    if (_passiveSpellLevel[6] < 15)
                    {
                        _passiveSpellLevel[6] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[10]) // rain
                {
                    _spellsLevel[1] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[11]) // bomb
                {
                    _spellsLevel[2] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                kek = true;
            }
            if (_isSprites[i].GetComponent<Image>().sprite == defaultSprite)
            {
                _isSprites[i].GetComponent<Image>().sprite = player.GetComponent<GivingSpells>()._slot[2].GetComponent<Image>().sprite;
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[0]) //speed
                {
                    if (_passiveSpellLevel[4] < 15)
                    {
                        _passiveSpellLevel[4] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[1]) // damagereduce
                {
                    if (_passiveSpellLevel[1] < 15)
                    {
                        _passiveSpellLevel[1] += 1;
                        player.GetComponent<Shield>().Working = true;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[2]) // damage
                {
                    if (_passiveSpellLevel[3] < 15)
                    {
                        _passiveSpellLevel[3] += 1;
                        player.GetComponent<AddDamage>().levelPlay++;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[3]) //Health heal
                {
                    if (_passiveSpellLevel[0] < 15)
                    {
                        _passiveSpellLevel[0] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[4]) // die aura
                {
                    _spellsLevel[0] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    _spellGO[0].SetActive(true);

                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[5]) // fireball
                {
                    _spellsLevel[3] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<FireBallScript>().Working = true;
                    player.GetComponent<FireBallScript>().spellIcon = _isSprites[i];
                    player.GetComponent<FireBallScript>().coldown = sliders[i];
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[6]) // fireclamp
                {
                    _spellsLevel[4] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    _spellGO[1].SetActive(true);
                    _spellGO[1].GetComponent<FireClamp>().workingClamp = true;
                    _spellGO[1].GetComponent<FireClamp>().spellIcon = _isSprites[i];
                    _spellGO[1].GetComponent<FireClamp>().coldownClamp = sliders[i];

                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[7]) // waterball
                {
                    _spellsLevel[5] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[8]) // waterculler
                {
                    _spellsLevel[6] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<WaterCuller>().Working = true;
                    player.GetComponent<WaterCuller>().spellIcon = _isSprites[i];
                    player.GetComponent<WaterCuller>().coldown = sliders[i];

                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[9]) // vampirizm
                {
                    if (_passiveSpellLevel[6] < 15)
                    {
                        _passiveSpellLevel[6] += 1;
                        player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    }
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[10]) // rain
                {
                    _spellsLevel[1] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<StarFailingWorking>().spellIcon = _isSprites[i];
                    player.GetComponent<StarFailingWorking>().coldown = sliders[i];
                }
                if (_isSprites[i].GetComponent<Image>().sprite == _chooseSprites[11]) // bomb
                {
                    _spellsLevel[2] += 1;
                    player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                    player.GetComponent<FireBombSpawner>().spellIcon = _isSprites[i];
                    player.GetComponent<FireBombSpawner>().coldown = sliders[i];
                }
                player.GetComponent<GivingSpells>()._skillPanel.SetActive(false);
                kek = true;
            }
        }
        Time.timeScale = 1f;
    }
    private void OnTriggerStay2D(Collider2D spawn)
    {
        if (spawn.gameObject.tag == "spawner")
        {
            spawn.GetComponent <Spawner>()._spawnTime = 0f;
            spawn.GetComponent<Spawner>().trigger = true;
        }
    }
    private void OnTriggerExit2D(Collider2D spawn)
    {
        if (spawn.gameObject.tag == "spawner")
        {
            spawn.GetComponent<Spawner>().trigger = false;
        }
    }

    public void Hitted()
    {
        hit.pitch = Random.Range(0.95f, 1.05f);
        hit.PlayOneShot(hitFX);
    }
    public void LevelUp()
    {
        levelUpSource.PlayOneShot(levelUpFx);
    }
    public void SavePlayer()
    {
        SaveSystem.SavePlayer(this);
    }
    public void Exit()
    {
        if (deathCount >= 4 || GM.GetComponent<GameManager>()._playingTime >= 180f)
        {
            ads.ShowAd();
            ads.LoadAd();
            deathCount = 0;
        }
    }
    public void Restart()
    {
        if (restartCount >= 5 || GM.GetComponent<GameManager>()._playingTime >= 180f)
        {
            ads.ShowAd();
            ads.LoadAd();
            restartCount = 0;
        }
        else
        {
            restartCount++;
        }
    }
    public void UpSomething()
    {
        levelUpAdd++;
        RestartAd();

    }
    public void RestartAd()
    {
        minAdd = Random.Range(levelUpAdd * 10, levelUpAdd * 20);
        maxAdd = Random.Range(levelUpAdd * 40, levelUpAdd * 50);
    }
    public void LoadPlayer()
    {
        PlayerData data = SaveSystem.LoadPlayer();
        _stats[3] = data.Money;
        _stats[0] = data.MaxHP;
        gameObject.GetComponent<achievements>().achievement[0] = data.KillingMonsters;
        gameObject.GetComponent<achievements>().achievement[1] = data.KilingBosses;
        gameObject.GetComponent<achievements>().achievement[2] = data. Deaths;
        gameObject.GetComponent<achievements>().achievement[3] = data.Earned;
        gameObject.GetComponent<AddDamage>().levelCur = data.levelDMG;
        gameObject.GetComponent<AddHealth>().levelCur= data.levelHP;
        gameObject.GetComponent<AddDamage>().costUp = data.costUpSave[0];
        gameObject.GetComponent<AddHealth>().costUpHealth = data.costUpSave[1];
        for (int j = 0; j < gameObject.GetComponent<PlayerMoving>().JoysticksAll.Length; j++)
        {
            gameObject.GetComponent<PlayerMoving>().JoysticksAll[j].SetActive(data.joystickWhich[j]);
        }
        for (int i = 0; i < data.whichSkinOn.Length; i++)
        {
            gameObject.GetComponent<PlayerSkins>().whichOn[i] = data.whichSkinOn[i];
        }
        for (int a = 0; a < data.WhichBuy.Length; a++)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<SkinShop>().SkinsAll[a].buy = data.WhichBuy[a];
        }

    }

    public void Reset()
    { 
        for (int i = 0; i < gameObject.GetComponent<PlayerSkins>().whichOn.Length; i++)
        {
            gameObject.GetComponent<PlayerSkins>().whichOn[i] = false;
        }
        for (int a = 0; a < GameObject.FindGameObjectWithTag("Player").GetComponent<SkinShop>().SkinsAll.Length; a++)
        {
            GameObject.FindGameObjectWithTag("Player").GetComponent<SkinShop>().SkinsAll[a].buy = false;
        }
        GameObject.FindGameObjectWithTag("Player").GetComponent<SkinShop>().SkinsAll[0].buy = true;
        gameObject.GetComponent<PlayerSkins>().whichOn[0] = true;
        gameObject.GetComponent<achievements>().achievement[0] = 0;
        gameObject.GetComponent<achievements>().achievement[1] = 0;
        gameObject.GetComponent<achievements>().achievement[2] = 0;
        gameObject.GetComponent<achievements>().achievement[3] = 0;
        _stats[3] = 0;
        _stats[0] = 100;
        gameObject.GetComponent<AddDamage>().levelCur = 0;
        gameObject.GetComponent<AddHealth>().levelCur = 0;
        gameObject.GetComponent<AddDamage>().costUp = 50;
        gameObject.GetComponent<AddHealth>().costUpHealth = 50;
    }

    public void smallBuy()
    {
        _stats[3] += 990;
    }
    public void defaultBuy()
    {
        _stats[3] += 2990;
    }
    public void BigBuy()
    {
        _stats[3] += 4990;
    }
}

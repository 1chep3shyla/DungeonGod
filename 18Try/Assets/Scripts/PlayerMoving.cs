using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

[RequireComponent(typeof(Rigidbody2D), typeof(BoxCollider2D))]
public class PlayerMoving : MonoBehaviour
{

    [SerializeField] private Rigidbody2D rb;
    [SerializeField] private Joystick joystick;
    [SerializeField] private Vector2 MoveVelocity;
    public GameObject[] JoysticksAll;
    public GameObject[] toggleIs;
    public Joystick[] allJoysticks; //0 - left 1 - Dynamic 2 - right
    public GameObject Partical;
    [SerializeField] public float speed;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (JoysticksAll[0].activeSelf == true)
        {
            toggleIs[0].SetActive(true);
            toggleIs[1].SetActive(false);
            toggleIs[2].SetActive(true);
            toggleIs[3].SetActive(false);
            joystick = allJoysticks[0];
        }
        if (JoysticksAll[1].activeSelf == true)
        {
            toggleIs[0].SetActive(false);
            toggleIs[1].SetActive(true);
            toggleIs[2].SetActive(true);
            toggleIs[3].SetActive(false);
            joystick = allJoysticks[1];
        }
        if (JoysticksAll[2].activeSelf == true)
        {
            toggleIs[0].SetActive(true);
            toggleIs[1].SetActive(false);
            toggleIs[2].SetActive(false);
            toggleIs[3].SetActive(true);
            joystick = allJoysticks[2];
        }
        if (joystick.Horizontal < 0)
        {
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        if (joystick.Horizontal > 0)
        {
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        if (joystick.Horizontal == 0 && joystick.Vertical == 0)
        {
            Partical.SetActive(false);
        }
        else
        {
            Partical.SetActive(true);
        }
        Vector2 moveInput = new Vector2(joystick.Horizontal, joystick.Vertical);
        MoveVelocity = moveInput.normalized * speed;
    }

    private void FixedUpdate()
    {
        rb.MovePosition(rb.position + MoveVelocity * Time.deltaTime);
    }

}


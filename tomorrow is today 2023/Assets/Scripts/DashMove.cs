   using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.Tilemaps;

public class DashMove : MonoBehaviour
{
    private Rigidbody2D rb;
    public float dashSpeed;
    private float dashTime;
    public float startDashTime;
    private int direction;

    public ParticleSystem dashEffect;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        dashTime = startDashTime;

    }

    void Update()
    {
        void CreateDashEffect()
        {
            dashEffect.Play();
        }

        if (direction == 0)
        {
            if (Input.GetKey(KeyCode.LeftArrow) && Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Q) && Input.GetKey(KeyCode.Space))
            {
                CreateDashEffect();
                direction = 1;
            }
            else if (Input.GetKey(KeyCode.RightArrow) && Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.D) && Input.GetKey(KeyCode.Space))
            {
                CreateDashEffect();
                direction = 2;
            }
            else if (Input.GetKey(KeyCode.UpArrow) && Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.Z) && Input.GetKey(KeyCode.Space))
            {
                CreateDashEffect();
                direction = 3;
            }
            else if (Input.GetKey(KeyCode.DownArrow) && Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.S) && Input.GetKey(KeyCode.Space))
            {
                CreateDashEffect();
                direction = 4;
            }
            
        }
        else
        {
            if (dashTime <= 0)
            {
                direction = 0;
                dashTime = startDashTime;
                rb.velocity = Vector2.zero;
            }
            else
            {
                dashTime -= Time.deltaTime;
                if (direction == 1)
                {
                    rb.velocity = Vector2.left * dashSpeed;
                }
                if (direction == 2)
                {
                    rb.velocity = Vector2.right * dashSpeed;
                }
                if (direction == 3)
                {
                    rb.velocity = Vector2.up * dashSpeed;
                }
                if (direction == 4)
                {
                    rb.velocity = Vector2.down * dashSpeed;
                }
            }
        }
    }
}


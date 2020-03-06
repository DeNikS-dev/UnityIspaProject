using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

    public int speed; //Public даёт возможность не лазить постоянно в скрипт что бы менять значения. Все значения меняются в inspecor'e в unity
    public int jump; // int это переменная, в неё можно положить только целые числа. Сначала пишется переменна, потом название. Название не должно совпадать с классом
    private float movement = 0;

    bool isGround; //bool - переменная которая имеет 2 значение: true(Истина), false(Ложь)

    Rigidbody2D rb; //Rigdbody Это физика. 

    private void Start() // Метод Старт будет срабатывать только 1 раз, сразу после запуска
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update() //
    {
        movement = Input.GetAxis("Horizontal");
        if (movement > 0f)
        {
            rb.velocity = new Vector2(movement * speed, rb.velocity.y);

        }
        else if (movement < 0f)
        {
            rb.velocity = new Vector2(movement * speed, rb.velocity.y);

        }
        else
        {
            rb.velocity = new Vector2(0, rb.velocity.y);
        }
        if (Input.GetButton("Jump") && isGround == true)
        {
            rb.velocity = new Vector2(rb.velocity.x, jump);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isGround = true;
        }
    }
    private void OnCollisionExit2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "ground")
        {
            isGround = false;
        }
    }

}

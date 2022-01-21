using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] float playerMoveSpeed = 5f;

    Vector3 touchPos, direction;
    Rigidbody2D rb;
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        PlayerControl();
    }

    private void PlayerControl()
    {
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(0, playerMoveSpeed * Time.deltaTime, 0);
        }
        if (Input.touchCount > 0)
        {
            transform.Translate(0, playerMoveSpeed * Time.deltaTime, 0);
            Touch touch = Input.GetTouch(0);
            touchPos = Camera.main.ScreenToWorldPoint(touch.position);
            touchPos.z = 0f;
            direction = (touchPos - transform.position);
            rb.velocity = new Vector2(direction.x, 0) * playerMoveSpeed;

            if (touch.phase == TouchPhase.Ended)
            {
                rb.velocity = Vector2.zero;
            }
        }
    }
}

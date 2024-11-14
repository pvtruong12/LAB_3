using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class myCharz : MonoBehaviour
{
    // Start is called before the first frame update
    public float MoveSpeed = 1f;
    private Vector3 LocalPostions;
    private Vector3 VectorMove;
    private int count = 0;
    private long lastTimeUpdate;
    public int CoolDownClick = 100;
    public bool isDied;
    private Rigidbody2D rb;
    void Start()
    {
        LocalPostions = transform.localPosition;
        rb = GetComponent<Rigidbody2D>();
    }
    public static long currentTimeMillis()
    {
        DateTime dateTime = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
        return (DateTime.UtcNow.Ticks - dateTime.Ticks) / 10000;
    }

    void FixedUpdate()
    {
        count++;
        if(count >= 10)
        {
            if(currentTimeMillis() - lastTimeUpdate > CoolDownClick)
            {
                float x = Input.GetAxisRaw("Horizontal");
                float y = Input.GetAxisRaw("Vertical");
                if (x != 0 || y != 0)
                {
                    Vector2 movement = new Vector2(x, y).normalized * MoveSpeed;
                    rb.MovePosition(rb.position + movement * Time.fixedDeltaTime);
                }
                lastTimeUpdate = currentTimeMillis();
            }
            if(isDied)
            {
                isDied = false;
                transform.position = LocalPostions;
            }
        }
    }
    
}

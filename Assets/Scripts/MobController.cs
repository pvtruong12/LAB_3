using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MobController : MonoBehaviour
{
    private long lastTimeUpdate;
    public TMP_Text textm;
    public GameObject PanelWin;
    public static GameObject globalGameObj;
    private Rigidbody2D rb;
    private float fl = 1;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        globalGameObj = PanelWin;
    }

    void FixedUpdate()
    {
        if(myCharz.currentTimeMillis() - lastTimeUpdate > 2000)
        {
            transform.Translate(new Vector2(0, fl)); 
            fl = fl * -1;
            lastTimeUpdate = myCharz.currentTimeMillis();
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("myCharz"))
        {
            textm.text = "You Lose";
            PanelWin.SetActive(true);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MobRandom : MonoBehaviour
{
    private GameObject targetGameObject;
    public TMP_Text textm;
    private GameObject PanelWin;
    private long lastTimeUpdate;
    public float Speed= 10f;
    void Start()
    {
        targetGameObject = GameObject.Find("NhanVat");
        Destroy(gameObject, 20);
    }

    void FixedUpdate()
    {
        if(myCharz.currentTimeMillis() - lastTimeUpdate > 1000)
        {
            Vector3 target = targetGameObject.transform.position;
            if (transform.position != target)
                transform.position = Vector3.MoveTowards(transform.position, target, Speed* Time.fixedDeltaTime);
            lastTimeUpdate = myCharz.currentTimeMillis();
        }
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("myCharz"))
        {
            PanelWin =  MobController.globalGameObj;
            textm = PanelWin.transform.Find("TextLogo").GetComponent<TMP_Text>();
            textm.text = "You Lose";
            PanelWin.SetActive(true);
        }
    }
}

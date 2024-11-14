using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SetWin : MonoBehaviour
{
    // Start is called before the first frame update
    public TMP_Text textMesh;
    public GameObject PanelWin;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("myCharz"))
        {
            textMesh.text = "You Win";
            PanelWin.SetActive(true);
        }
    }
}

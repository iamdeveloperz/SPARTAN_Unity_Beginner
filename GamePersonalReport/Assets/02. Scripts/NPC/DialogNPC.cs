using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogNPC : MonoBehaviour
{
    public GameObject npcDialog;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        npcDialog.SetActive(true);
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        npcDialog.SetActive(false);
    }
}
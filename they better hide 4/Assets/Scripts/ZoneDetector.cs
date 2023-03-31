using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ZoneDetector : MonoBehaviour
{
    public GameObject sucessText;
    public GameObject noSucessText;
    //public Text messageText;

    public bool playerInside;

    private void OnTriggerEnter(Collider other)
    {
        // Vérifie si le joueur entre dans la zone
        if (other.gameObject.CompareTag("Player"))
        {
            playerInside = true;
            sucessText.SetActive(true);
            noSucessText.SetActive(false);
            //messageText.gameObject.SetActive(true);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        // Vérifie si le joueur quitte la zone
        if (other.gameObject.CompareTag("Player"))
        {
            playerInside = false;
            //messageText.gameObject.SetActive(false);
        }
    }
}

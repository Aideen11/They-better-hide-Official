using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public GameObject door;
    public GameObject interactText;
    public GameObject door1;

    public GameObject succesText;

    public Animator animator;

    bool isTrigger;

    public string interactibleObjectName = "Door";
    public string interactibleObjectName1 = "Door1";

    public float maxDistance = 1f;


    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance)) // V�rifie si vous regardez l'objet et �tes suffisamment proche
        {
            Debug.Log(hit.collider.gameObject.name);
            Debug.DrawLine(transform.position, transform.position + transform.forward * maxDistance, Color.red);
            if (hit.collider.gameObject.name == interactibleObjectName) // V�rifie si l'objet touch� est bien l'objet attach� � ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // V�rifie si vous appuyez sur la touche "e"
                {
                    animator.SetBool("isTrigger", true);
                    succesText.SetActive(true);
                    //door.SetActive(false);
                }
            }
            if (hit.collider.gameObject.name == interactibleObjectName1) // V�rifie si l'objet touch� est bien l'objet attach� � ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // V�rifie si vous appuyez sur la touche "e"
                {
                    door1.SetActive(false);
                }
            }
            else
            {
                interactText.gameObject.SetActive(false); // Masque le texte UI si vous ne regardez plus l'objet ou �tes trop loin
            }
        }
        else
        {
            interactText.gameObject.SetActive(false); // Masque le texte UI si vous ne regardez plus l'objet ou �tes trop loin
        }

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    public GameObject indice1;
    public GameObject indice2;
    public GameObject indice3;
    public GameObject indice4;
    public GameObject indice5;

    public GameObject npc1;
    public GameObject npc2;
    public GameObject npc3;
    public GameObject npc4;
    public GameObject npc5;
    public GameObject npc6;
    public GameObject npc7;
    public GameObject npc8;
    public GameObject npc9;
    public GameObject npc10;
    public GameObject npc11;
    public GameObject npc12;
    public GameObject npc13;

    public GameObject npc14;
    public GameObject npc15;
    public GameObject npc16;
    public GameObject npc17;

    public GameObject npc18;

    public GameObject door;
    public GameObject door1;

    public GameObject successText1;
    public GameObject noSuccessText1;
    public GameObject successText2;
    public GameObject noSuccessText2;
    public GameObject successText3;
    public GameObject noSuccessText3;
    public GameObject successText4;
    public GameObject noSuccessText4;
    public GameObject successText5;
    public GameObject noSuccessText5;

    public GameObject successText6;
    public GameObject noSuccessText6;
    public GameObject successText7;
    public GameObject noSuccessText7;

    public GameObject successTextnpc0;
    public GameObject successTextnpc1;
    public GameObject successTextnpc2;
    public GameObject successTextnpc3;
    public GameObject successTextnpc4;
    public GameObject successTextnpc5;
    public GameObject successTextnpc6;

    public GameObject dialogue1;
    public GameObject dialogue2;
    public GameObject dialogue3;
    public GameObject dialogue4;
    public GameObject dialogue5;
    public GameObject dialogue6;


    public bool quest1 = false;

    public GameObject interactText;

    public string interactibleObjectName1 = "Cube";
    public string interactibleObjectName2 = "Cube";
    public string interactibleObjectName3 = "Cube";
    public string interactibleObjectName4 = "Cube";
    public string interactibleObjectName5 = "Cube";
    public string interactibleObjectName6 = "Cube";
    public string interactibleObjectName7 = "Cube";
    public string interactibleObjectName8 = "Cube";
    public string interactibleObjectName9 = "Cube";
    public string interactibleObjectName10 = "Cube";
    public string interactibleObjectName11 = "Cube";
    public string interactibleObjectName12 = "Cube";

    public float maxDistance = 5f;

    public float successMessageDuration = 2.0f;


    void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, maxDistance)) // Vérifie si vous regardez l'objet et êtes suffisamment proche
        {
            Debug.Log(hit.collider.gameObject.name);
            //Debug.DrawLine(transform.position, transform.position + transform.forward * maxDistance, Color.red);
            if (hit.collider.gameObject.name == interactibleObjectName1) // Vérifie si l'objet touché est bien l'objet attaché à ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                    // Faites disparaître l'objet et affichez le message de réussite
                    indice1.SetActive(false);
                    noSuccessText1.SetActive(false);
                    successText1.SetActive(true);

                    //Invoke("HideSuccessText", successMessageDuration);
                }
            }
            if (hit.collider.gameObject.name == interactibleObjectName2) // Vérifie si l'objet touché est bien l'objet attaché à ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                    // Faites disparaître l'objet et affichez le message de réussite
                    indice2.SetActive(false);
                    noSuccessText2.SetActive(false);
                    successText2.SetActive(true);

                    //Invoke("HideSuccessText", successMessageDuration);
                }
            }
            if (hit.collider.gameObject.name == interactibleObjectName3) // Vérifie si l'objet touché est bien l'objet attaché à ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                    // Faites disparaître l'objet et affichez le message de réussite
                    indice3.SetActive(false);
                    noSuccessText3.SetActive(false);
                    successText3.SetActive(true);

                    //Invoke("HideSuccessText", successMessageDuration);
                }
            }
            if (hit.collider.gameObject.name == interactibleObjectName4) // Vérifie si l'objet touché est bien l'objet attaché à ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                    // Faites disparaître l'objet et affichez le message de réussite
                    indice4.SetActive(false);
                    noSuccessText4.SetActive(false);
                    successText4.SetActive(true);

                    //Invoke("HideSuccessText", successMessageDuration);
                }
            }

            if (hit.collider.gameObject.name == interactibleObjectName6) // Vérifie si l'objet touché est bien l'objet attaché à ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                    // Faites disparaître l'objet et affichez le message de réussite
                    dialogue1.SetActive(true);
                    StartCoroutine(Dialogue1());

                    if (successTextnpc0.activeInHierarchy)
                    {
                        successTextnpc0.SetActive(false);
                        successTextnpc1.SetActive(true);
                    }
                    else if(successTextnpc1.activeInHierarchy)
                    {
                        successTextnpc1.SetActive(false);
                        successTextnpc2.SetActive(true);
                    }
                    else if(successTextnpc2.activeInHierarchy)
                    {
                        successTextnpc2.SetActive(false);
                        successTextnpc3.SetActive(true);
                    }

                    //Invoke("HideSuccessText", successMessageDuration);
                }
                //Invoke("HideSuccesText1", successMessageDuration);
            }
            if (hit.collider.gameObject.name == interactibleObjectName7) // Vérifie si l'objet touché est bien l'objet attaché à ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                    // Faites disparaître l'objet et affichez le message de réussite
                    dialogue2.SetActive(true);
                    StartCoroutine(Dialogue2());

                    if (successTextnpc0.activeInHierarchy)
                    {
                        successTextnpc0.SetActive(false);
                        successTextnpc1.SetActive(true);
                    }
                    else if (successTextnpc1.activeInHierarchy)
                    {
                        successTextnpc1.SetActive(false);
                        successTextnpc2.SetActive(true);
                    }
                    else if (successTextnpc2.activeInHierarchy)
                    {
                        successTextnpc2.SetActive(false);
                        successTextnpc3.SetActive(true);
                    }
                }
                //Invoke("HideSuccesText2", successMessageDuration);
            }
            if (hit.collider.gameObject.name == interactibleObjectName8) // Vérifie si l'objet touché est bien l'objet attaché à ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                  
                    dialogue3.SetActive(true);
                    StartCoroutine(Dialogue3());

                    if (successTextnpc0.activeInHierarchy)
                    {
                        successTextnpc0.SetActive(false);
                        successTextnpc1.SetActive(true);
                    }
                    else if (successTextnpc1.activeInHierarchy)
                    {
                        successTextnpc1.SetActive(false);
                        successTextnpc2.SetActive(true);
                    }
                    else if (successTextnpc2.activeInHierarchy)
                    {
                        successTextnpc2.SetActive(false);
                        successTextnpc3.SetActive(true);
                    }

                    //Invoke("HideSuccessText", successMessageDuration);
                }

                //Invoke("HideSuccesText3", successMessageDuration);
            }

            if (hit.collider.gameObject.name == interactibleObjectName9) // Vérifie si l'objet touché est bien l'objet attaché à ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                    // Faites disparaître l'objet et affichez le message de réussite
                    indice5.SetActive(false);
                    noSuccessText6.SetActive(false);
                    successTextnpc4.SetActive(true);

                    //Invoke("HideSuccessText", successMessageDuration);
                }
            }

            if (hit.collider.gameObject.name == interactibleObjectName10)
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                    // Faites disparaître l'objet et affichez le message de réussite
                    dialogue4.SetActive(true);
                    StartCoroutine(Dialogue4());

                    if (successTextnpc4.activeInHierarchy)
                    {
                        successTextnpc4.SetActive(false);
                        successTextnpc5.SetActive(true);
                    }
                    else if (successTextnpc5.activeInHierarchy)
                    {
                        successTextnpc5.SetActive(false);
                    }
                }
                //Invoke("HideSuccesText2", successMessageDuration);
            }

            if (hit.collider.gameObject.name == interactibleObjectName11) // Vérifie si l'objet touché est bien l'objet attaché à ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                    // Faites disparaître l'objet et affichez le message de réussite
                    dialogue5.SetActive(true);
                    StartCoroutine(Dialogue5());

                    if (successTextnpc4.activeInHierarchy)
                    {
                        successTextnpc4.SetActive(false);
                        successTextnpc5.SetActive(true);
                    }
                    else if (successTextnpc5.activeInHierarchy)
                    {
                        successTextnpc5.SetActive(false);
                        successTextnpc6.SetActive(true);
                    }
                }
                //Invoke("HideSuccesText2", successMessageDuration);
            }

            if (hit.collider.gameObject.name == interactibleObjectName12) // Vérifie si l'objet touché est bien l'objet attaché à ce script
            {
                interactText.gameObject.SetActive(true); // Affiche le texte UI "Press E"
                if (Input.GetKeyDown(KeyCode.E)) // Vérifie si vous appuyez sur la touche "e"
                {
                    // Faites disparaître l'objet et affichez le message de réussite
                    dialogue6.SetActive(true);
                    StartCoroutine(Dialogue6());
                }
                //Invoke("HideSuccesText2", successMessageDuration);
            }

            else
            {
                interactText.gameObject.SetActive(false); // Masque le texte UI si vous ne regardez plus l'objet ou êtes trop loin
            }

        }

       

        if (successText1.activeInHierarchy && successText2.activeInHierarchy && successText3.activeInHierarchy && successText4.activeInHierarchy)
        {

            door.SetActive(false);

            successText1.SetActive(false);
            successText2.SetActive(false);
            successText3.SetActive(false);
            successText4.SetActive(false);
            successText5.SetActive(false);

            successTextnpc0.SetActive(true);

        }

        if(successTextnpc3.activeInHierarchy)
        {
            successTextnpc3.SetActive(false);
            noSuccessText5.SetActive(true);
        }
        if(noSuccessText6.activeInHierarchy)
        {
            door1.SetActive(false);
            noSuccessText5.SetActive(false);
        }

        if(successTextnpc6.activeInHierarchy)
        {
            successTextnpc6.SetActive(false);
            noSuccessText7.SetActive(true);
        }

        else
        {
            //interactText.gameObject.SetActive(false); // Masque le texte UI si vous ne regardez plus l'objet ou êtes trop loin
        }
    }

    private IEnumerator Dialogue1()
    {
        yield return new WaitForSeconds(2f);
        dialogue1.SetActive(false);
    }

    private IEnumerator Dialogue2()
    {
        yield return new WaitForSeconds(2f);
        dialogue2.SetActive(false);
    }

    private IEnumerator Dialogue3()
    {
        yield return new WaitForSeconds(2f);
        dialogue3.SetActive(false);
    }

    private IEnumerator Dialogue4()
    {
        yield return new WaitForSeconds(2f);
        dialogue4.SetActive(false);
    }

    private IEnumerator Dialogue5()
    {
        yield return new WaitForSeconds(2f);
        dialogue5.SetActive(false);
    }

    private IEnumerator Dialogue6()
    {
        yield return new WaitForSeconds(2f);
        dialogue6.SetActive(false);
    }

}

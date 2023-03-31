using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu; // Le menu de pause à activer/désactiver
    public GameObject canva;

    bool isPaused = false; // Indique si le jeu est en pause ou non
    bool isTab = false;

    void Start()
    {
        Cursor.visible = false; // Affiche la souris dans le jeu
        Cursor.lockState = CursorLockMode.Locked; // Verrouille le curseur au centre de l'écran
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (!isPaused)
            {
                Time.timeScale = 0; // Met le temps en pause
                Cursor.visible = true; // Affiche la souris dans le jeu
                Cursor.lockState = CursorLockMode.None; // Déverrouille le curseur pour interagir avec le menu de pause
                pauseMenu.SetActive(true); // Active le menu de pause
                canva.SetActive(false);

                isPaused = true; // Le jeu est maintenant en pause
            }
            else
            {
                Time.timeScale = 1; // Remet le temps en marche
                Cursor.visible = false; // Cache la souris dans le jeu
                Cursor.lockState = CursorLockMode.Locked; // Verrouille le curseur au centre de l'écran
                pauseMenu.SetActive(false); // Désactive le menu de pause
                canva.SetActive(true);

                isPaused = false; // Le jeu n'est plus en pause
            }
        }

        if(Input.GetKeyDown(KeyCode.Tab))
        {
            if(!isTab && !isPaused)
            {
                canva.SetActive(false);

                isTab = true;
            }
            else if(isPaused == false)
            {
                canva.SetActive(true);

                isTab = false;
            }
        }
    }

    public void OnApplicationQuit()
    {
        Application.Quit();
    }
}

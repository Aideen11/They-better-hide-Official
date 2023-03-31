using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseMenu : MonoBehaviour
{
    public GameObject pauseMenu; // Le menu de pause à activer/désactiver
    bool isPaused = false; // Indique si le jeu est en pause ou non

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
                isPaused = true; // Le jeu est maintenant en pause
            }
            else
            {
                Time.timeScale = 1; // Remet le temps en marche
                Cursor.visible = false; // Cache la souris dans le jeu
                Cursor.lockState = CursorLockMode.Locked; // Verrouille le curseur au centre de l'écran
                pauseMenu.SetActive(false); // Désactive le menu de pause
                isPaused = false; // Le jeu n'est plus en pause
            }
        }
    }
}

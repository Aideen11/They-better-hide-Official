using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleportation : MonoBehaviour
{
    public KeyCode teleportKey = KeyCode.Escape;

    public Transform teleportPosition1;
    public Transform teleportPosition2;
    public Transform teleportPosition3;
    public Transform teleportPosition4;
    public Transform teleportPosition5;
    public GameObject player;

    void Update()
    {
        //if (Input.GetKeyDown(teleportKey))
        //{
        //    TeleportPlayer();
        //}
    }

    public void Teleporter1Player()
    {
        // T�l�porte le joueur � la position de t�l�portation
        player.transform.position = teleportPosition1.position;
    }

    public void Teleporter2Player()
    {
        // T�l�porte le joueur � la position de t�l�portation
        player.transform.position = teleportPosition2.position;
    }

    public void Teleporter3Player()
    {
        // T�l�porte le joueur � la position de t�l�portation
        player.transform.position = teleportPosition3.position;
    }

    public void Teleporter4Player()
    {
        // T�l�porte le joueur � la position de t�l�portation
        player.transform.position = teleportPosition4.position;
    }

    public void Teleporter5Player()
    {
        // T�l�porte le joueur � la position de t�l�portation
        player.transform.position = teleportPosition5.position;
    }
}

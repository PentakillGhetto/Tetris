﻿using UnityEngine;
using System.Collections;

public class menuController : MonoBehaviour {
    private GameObject game;

    void Awake() { game = GameObject.FindGameObjectWithTag("Game"); }

    public void buttonStartGame() {
        game.SetActive(true);
        game.GetComponent<gameController>().newGame();
        gameObject.SetActive(false);
    }

    public void buttonExitGame() { Application.Quit(); }
}

﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TourController : MonoBehaviour {

    private HudUI hud;
    private Restart restart;

    void Awake()
    {
        hud = (HudUI)FindObjectOfType(typeof(HudUI));
        restart = (Restart)FindObjectOfType(typeof(Restart));
    }

    void OnEnable()
    {
        hud.NewTour += DisplayNewTour;
        restart.NewLevel += UpgradeLevel;
        restart.RestartEnabled += NewTourStartIsAvailable;
    }

    void OnDisable()
    {
        hud.NewTour -= DisplayNewTour;
        restart.NewLevel -= UpgradeLevel;
        restart.RestartEnabled -= NewTourStartIsAvailable;
    }

    private void DisplayNewTour()
    {
        hud.tour.GetComponent<Text>().text = "Tour: " + GameState.instance.Tour.CurrentTour.level;
    }

    public bool NewTourStartIsAvailable()
    {
        return GameState.instance.Currency.NumberOfFans > GameState.instance.Tour.CurrentTour.fanRequirementToSkip;
    }

    private void UpgradeLevel()
    {
        GameState.instance.Tour.CurrentTourID += 1;
        GameState.instance.Currency.NumberOfCoins = 0;
        GameState.instance.Currency.NumberOfFans = 0;
    }
}

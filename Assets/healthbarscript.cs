using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class healthbarscript : MonoBehaviour
{
    private Image HealthBar;
    public float CurrentHealth;
    private float MaxHealth = 100;
    PlayerControllerScript Player;

    private void Start()
    {
    HealthBar =  GetComponent<Image>();
    Player = FindObjectOfType<PlayerControllerScript>();
    }

    private void Update()
    {
    	CurrentHealth = Player.Health;
    	HealthBar.fillAmount = CurrentHealth / MaxHealth;
    }
}

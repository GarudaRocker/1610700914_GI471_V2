using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class W5_HealthBar : MonoBehaviour
{
    public Image healthBar;   
    public float playerMaxHP = 100.0f;
    public float regenRate = 5.0f;
    public float playerCurrentHP;

    private W5_StatusSystem player_Hp;

    private void Start()
    {
        healthBar = GetComponent<Image>();

        player_Hp = FindObjectOfType<W5_StatusSystem>();
    }

    private void Update()
    {
        playerCurrentHP = player_Hp.playerHP;

        if (playerCurrentHP < playerMaxHP)
        {
            player_Hp.playerHP += regenRate * Time.deltaTime;
        }

        healthBar.fillAmount = playerCurrentHP / playerMaxHP;
    }

}

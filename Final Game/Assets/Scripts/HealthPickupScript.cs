using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HealthPickupScript : MonoBehaviour
{
    public PlayerController playerController;
    public HealthText healthText;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player)").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerController.curHp += 2;
            Destroy(gameObject);
            healthText.IncreaseHealthText(2);
        }
    }
}

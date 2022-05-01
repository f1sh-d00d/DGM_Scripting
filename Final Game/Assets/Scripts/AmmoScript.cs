using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class AmmoScript : MonoBehaviour
{
    public PlayerController playerController;
    public AmmoText ammoText;

    // Start is called before the first frame update
    void Start()
    {
        playerController = GameObject.Find("Player)").GetComponent<PlayerController>();
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            playerController.ammo += 25;
            Destroy(gameObject);
            ammoText.IncreaseAmmoText(25);
        }
    }
}

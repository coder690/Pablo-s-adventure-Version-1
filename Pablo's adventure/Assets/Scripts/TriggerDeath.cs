using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDeath : MonoBehaviour
{
    public GameObject player;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        player.GetComponent<MarioDeath>().DeathPlay();
        Debug.Log("deathTrigged!");
    }
}

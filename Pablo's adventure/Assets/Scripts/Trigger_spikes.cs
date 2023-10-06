using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Trigger_spikes : MonoBehaviour
{
    public Animator animate;
    public GameObject player;
    public void Start()
    {
        gameObject.gameObject.SetActive(true);
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            gameObject.gameObject.SetActive(false);
            animate.enabled = true;
        }
    }

    public void Update()
    {
        
    }


}

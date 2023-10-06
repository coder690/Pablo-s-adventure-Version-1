using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioDeath : MonoBehaviour
{
    public SpriteRenderer deadSprite;

    public void Start()
    {
        //deadSprite = GetComponent<SpriteRenderer>();
        //deadSprite.enabled = false;
    }
    public void DeathPlay()
    {
        deadSprite.enabled = true;
        //gameObject.GetComponent<SpriteRenderer>().enabled = false;
    }
}

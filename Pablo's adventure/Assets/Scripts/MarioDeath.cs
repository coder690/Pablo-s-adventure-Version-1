using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MarioDeath : MonoBehaviour
{
    public SpriteRenderer spriteR;

    public Sprite[] sprites;

    public void Start()
    {
        //sprites = Resources.LoadAll<sprite>(spriteNames);
    }

    public void DeathPlay()
    {
        //sprite.sprite = Death;
        Debug.Log("Hi");
    }
}

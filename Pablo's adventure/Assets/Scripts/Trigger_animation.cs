using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger_animation : MonoBehaviour
{
    public string animationName;
    public Animator animator;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        animator.Play(animationName);
    }
}

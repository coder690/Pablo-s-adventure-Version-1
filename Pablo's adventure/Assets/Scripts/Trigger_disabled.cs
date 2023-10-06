using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class Trigger_disabled : MonoBehaviour
{
    public GameObject objectName;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        objectName.SetActive(false);
    }
}

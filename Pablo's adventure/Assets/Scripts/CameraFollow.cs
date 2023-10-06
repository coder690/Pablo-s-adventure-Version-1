using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject cameraFollow;

    void Update()
    {
        transform.position = cameraFollow.transform.position;
    }
}

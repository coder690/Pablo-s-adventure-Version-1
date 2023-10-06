using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraFollow : MonoBehaviour
{
    public GameObject cameraFollow;
    public float yControl;


    private void Start()
    {
        yControl = 2.5f;
    }
    void Update()
    {
        var position = cameraFollow.transform.position;
        position.y = yControl;
        transform.position = position;
    }
}

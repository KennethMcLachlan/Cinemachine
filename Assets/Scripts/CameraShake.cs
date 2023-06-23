using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraShake : MonoBehaviour
{
    private CinemachineImpulseSource _source;

    void Start()
    {
        _source = GetComponent<CinemachineImpulseSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.X))
        {
            Shake();
        }
    }

    public void Shake()
    {
        _source.GenerateImpulse();
    }
}

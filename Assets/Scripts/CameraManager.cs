using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] _cameras;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ResetAllCams()
    {
        foreach (var c in _cameras)
        {
            c.GetComponent<CinemachineVirtualCamera>().Priority = 10;
        }

    }

    public void SetMasterCam(int cam)
    {
        _cameras[cam].GetComponent<CinemachineVirtualCamera>().Priority = 15;
    }
}

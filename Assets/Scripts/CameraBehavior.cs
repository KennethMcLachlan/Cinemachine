using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cinemachine;

public class CameraBehavior : MonoBehaviour
{
    [SerializeField]
    private GameObject _target01;

    [SerializeField]
    private GameObject _target02;

    [SerializeField]
    private GameObject _VC01;

    [SerializeField]
    private GameObject _3rdPerCam;

    [SerializeField]
    private GameObject _orbitCamera;

    [SerializeField]
    private GameObject _VCHigh;

    [SerializeField]
    private GameObject _VCStill;

    [SerializeField]
    private GameObject _VCTrack;

    [SerializeField]
    private GameObject _player;

    private CinemachineVirtualCamera _camera;

    private int[] _cameraSwitch;

    private bool _firstTarget;
    void Start()
    {
        _camera = GetComponent<CinemachineVirtualCamera>();

        _camera.m_Lens.FieldOfView = 40;
    }

    
    void Update()
    {
        
        if (Input.GetKeyDown(KeyCode.R))
        {
            SwitchTarget();
        }

        if (Input.GetKey(KeyCode.Mouse1))
        {
            _3rdPerCam.SetActive(false);
        }
        else _3rdPerCam.SetActive(true);

        if (Input.GetKeyDown(KeyCode.Space))
        {
           float FOV = _VC01.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView -= 20;

            if (FOV < 10)
            {
                _VC01.GetComponent<CinemachineVirtualCamera>().m_Lens.FieldOfView = 60;
            }
        }
    }

    private void SwitchTarget()
    {
        if (_firstTarget == true)
        {
            _VC01.GetComponent<CinemachineVirtualCamera>().LookAt = _target01.transform;
            _firstTarget = false;
        }
        else if (_firstTarget == false)
        {
            _VC01.GetComponent<CinemachineVirtualCamera>().LookAt = _target02.transform;
            _firstTarget = true;
        }
    }

    private void CameraSwitch()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        
    }
}

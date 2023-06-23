using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwitchTrigger : MonoBehaviour
{
    [SerializeField]
    private int _whichCamera;

    private CameraManager _camManager;
    void Start()
    {
        _camManager = GameObject.Find("Managers").GetComponent<CameraManager>();
    }

    
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            _camManager.ResetAllCams();
            _camManager.SetMasterCam(_whichCamera);
        }
    }
}

using Cinemachine;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class SwitchCamara : MonoBehaviour
{
    [SerializeField] private CinemachineVirtualCamera Camera1;
    [SerializeField] private CinemachineVirtualCamera Camera2;
    [SerializeField] private CinemachineVirtualCamera PlayerCamera;
    [SerializeField] private int manager;

    private void Awake()
    {
        Camera1.gameObject.SetActive(false);
        Camera2.gameObject.SetActive(false);
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            managerControl();
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            returnToPlayer();
        }
    }

    private void managerControl()
    {

        if (manager == 0)
        {
            controlCam1();
            manager = 1;
        }
        else
        {
            controlCam2();
            manager = 0;
        }
        
    }

    private void controlCam1()
    {
        Camera1.gameObject.SetActive(true);
        Camera2.gameObject.SetActive(false);
        
    }

    private void controlCam2()
    {
        Camera1.gameObject.SetActive(false);
        Camera2.gameObject.SetActive(true);
    }

    private void returnToPlayer()
    {
        PlayerCamera.gameObject.SetActive(true);
        Camera1.gameObject.SetActive(false);
        Camera2.gameObject.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

public class GunsDo : MonoBehaviour
{
    [SerializeField] GameObject Gun;
    private Transform position1;
    private Transform position2;

    void Start()
    {
        position1 = Gun.transform;
        position2 = position1;
    }


    void Update()
    {
        
    }

    public void blowback()
    {
        float zRotation;
        float yRotation;
        float xRotation;
        System.Random rand = new System.Random();

        int a = rand.Next(0, 9);

        switch (a)
        {
            case 0:
                zRotation = Gun.transform.localRotation.z - 0.1f;
                yRotation = Gun.transform.localRotation.y + 1f;
                xRotation = Gun.transform.localRotation.x;
                Gun.transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
                break;
            case 1:
                zRotation = Gun.transform.localRotation.z - 0.2f;
                yRotation = Gun.transform.localRotation.y - 1f;
                xRotation = Gun.transform.localRotation.x;
                Gun.transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
                break;
            case 2:
                zRotation = Gun.transform.localRotation.z - 0.3f;
                yRotation = Gun.transform.localRotation.y + 2f;
                xRotation = Gun.transform.localRotation.x;
                Gun.transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
                break;
            case 3:
                zRotation = Gun.transform.localRotation.z - 0.4f;
                yRotation = Gun.transform.localRotation.y - 2f;
                xRotation = Gun.transform.localRotation.x;
                Gun.transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
                break;
            case 4:
                zRotation = Gun.transform.localRotation.z - 0.5f;
                yRotation = Gun.transform.localRotation.y + 1.5f;
                xRotation = Gun.transform.localRotation.x;
                Gun.transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
                break;
            case 5:
                zRotation = Gun.transform.localRotation.z - 0.6f;
                yRotation = Gun.transform.localRotation.y - 1.5f;
                xRotation = Gun.transform.localRotation.x;
                Gun.transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
                break;
            case 6:
                zRotation = Gun.transform.localRotation.z - 0.7f;
                yRotation = Gun.transform.localRotation.y + 0.5f;
                xRotation = Gun.transform.localRotation.x;
                Gun.transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
                break;
            case 7:
                zRotation = Gun.transform.localRotation.z - 0.8f;
                yRotation = Gun.transform.localRotation.y - 0.5f;
                xRotation = Gun.transform.localRotation.x;
                Gun.transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
                break;
            case 8:
                zRotation = Gun.transform.localRotation.z - 0.9f;
                yRotation = Gun.transform.localRotation.y + 0.25f;
                xRotation = Gun.transform.localRotation.x;
                Gun.transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
                break;
            case 9:
                zRotation = Gun.transform.localRotation.z - 1.0f;
                yRotation = Gun.transform.localRotation.y - 0.25f;
                xRotation = Gun.transform.localRotation.x;
                Gun.transform.localRotation = Quaternion.Euler(xRotation, yRotation, zRotation);
                break;
        }
    }












}

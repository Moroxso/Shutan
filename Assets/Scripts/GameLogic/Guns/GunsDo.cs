using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using System;

public class GunsDo : MonoBehaviour
{
    [SerializeField] GameObject Gun;
    [SerializeField] float returnSpeed = 5f;
    private Quaternion initialRotation;

    void Start()
    {
        initialRotation = Gun.transform.localRotation;
    }

    void Update()
    {
        // Плавно возвращаем оружие в исходное положение
        if (Gun.transform.localRotation != initialRotation)
        {
            Gun.transform.localRotation = Quaternion.Lerp(
                Gun.transform.localRotation,
                initialRotation,
                Time.deltaTime * returnSpeed
            );
        }
    }

    public void blowback()
    {
        System.Random rand = new System.Random();
        int a = rand.Next(0, 9);

        Vector3 recoilVector = Vector3.zero;

        switch (a)
        {
            case 0: recoilVector = new Vector3(0, 1f, -0.1f); break;
            case 1: recoilVector = new Vector3(0, -1f, -0.2f); break;
            case 2: recoilVector = new Vector3(0, 2f, -0.3f); break;
            case 3: recoilVector = new Vector3(0, -2f, -0.4f); break;
            case 4: recoilVector = new Vector3(0, 1.5f, -0.5f); break;
            case 5: recoilVector = new Vector3(0, -1.5f, -0.6f); break;
            case 6: recoilVector = new Vector3(0, 0.5f, -0.7f); break;
            case 7: recoilVector = new Vector3(0, -0.5f, -0.8f); break;
            case 8: recoilVector = new Vector3(0, 0.25f, -0.9f); break;
            case 9: recoilVector = new Vector3(0, -0.25f, -1.0f); break;
        }

        // Применяем отдачу к начальному повороту
        Gun.transform.localRotation = initialRotation * Quaternion.Euler(recoilVector);
    }
}
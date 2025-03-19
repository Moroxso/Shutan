using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDo : MonoBehaviour
{
    [SerializeField] GameObject Ballet;
    [SerializeField] Transform SpawnBallet;
    [SerializeField] Transform parent;

    //---------------------------------

    GameObject Camera;
    Camera ComponentCamera;

    //---------------------------------

    private float lastAttackTime = 0f;
    private float attackInterval = 0.0625f;

    //---------------------------------

    public int ammo = 30;
    public int cartridges = 6;
    private int allamountammo;

    //---------------------------------

    [SerializeField] private AudioClip Reload;
    [SerializeField] private AudioClip CanNotReload;

    //---------------------------------

    AudioSource sounds;

    //---------------------------------

    private void Start()
    {
        Camera = GameObject.Find("Camera");
        ComponentCamera = Camera.GetComponent<Camera>();
        sounds = this.gameObject.GetComponent<AudioSource>();

        allamountammo = ammo * cartridges;

    }


    void FixedUpdate()
    {
        Action();
    }

    private void Action()
    {
        if (Input.GetKey(KeyCode.Mouse0) && Time.time - lastAttackTime >= attackInterval)
        {
            Debug.Log($"Ammo: {ammo} | Cartridges: {cartridges} | AllAmmo: {allamountammo} ");

            if (ammo > 0 && allamountammo > 0)
            {
                Instantiate(Ballet, SpawnBallet.position, SpawnBallet.rotation, parent);
                lastAttackTime = Time.time;
                ammo--;
                allamountammo--;
            }
            else if (ammo <= 0 && cartridges > 0)
            { 
                cartridges--;
                ammo = 30;
                sounds.clip = Reload;
                sounds.Play();
            }
            else if (ammo <= 0 && cartridges <= 0)
            {
                sounds.clip = CanNotReload;
                sounds.Play();
            }
        }
        if (Input.GetKey(KeyCode.R))
        {
            if (cartridges > 1)
            {
                ammo = 30;

            }
            else if (cartridges == 1)
            {
                ammo = allamountammo;
            }
            else if (cartridges < 1)
            {
                sounds.clip = CanNotReload;
                sounds.Play();
            }

            sounds.clip = Reload;
            sounds.Play();

        }
        if (Input.GetKeyDown(KeyCode.Mouse1))
        {
            ComponentCamera.fieldOfView = 30f;
            
        }
        if (Input.GetKeyUp(KeyCode.Mouse1))
        {
            ComponentCamera.fieldOfView = 60f;
        }


    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptBallets : MonoBehaviour
{
    [SerializeField] GameObject Ballet;

    private int damage = 1;


    private void FixedUpdate()
    {
        Ballet.transform.Translate(Vector3.forward * Time.deltaTime * 15f);
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("AI"))
        {
            AI ai = other.gameObject.GetComponent<AI>();
            ai.damage(damage);
        }




        Destroy(Ballet);
    }


}

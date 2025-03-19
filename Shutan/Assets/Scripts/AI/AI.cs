using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AI : MonoBehaviour
{
    NavMeshAgent navMeshAgent;
    GameObject Player;

    //-----------------------------

    public int hp = 10;

    //-----------------------------

    public float distance = 10f;

    //-----------------------------


    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        Player = GameObject.Find("Player");
    }


    void Update()
    {
        if (distance >= Vector3.Distance(transform.position, Player.transform.position))
        {
            navMeshAgent.SetDestination(Player.transform.position);
        }
    }

    public void damage(int damage)
    {
        hp = hp - damage;
        if (hp <= 0)
        {
            die();
        }
    }

    void die()
    {
        Destroy(this.gameObject);
    }




}

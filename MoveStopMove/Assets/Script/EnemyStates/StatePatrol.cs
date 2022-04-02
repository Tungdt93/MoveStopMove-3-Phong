using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class StatePatrol : MonoBehaviour, IStates
{



    public void OnEnter(Enemy enemy)
    {

    }


    public void OnExecute(Enemy enemy)
    {
        enemy.Patrol();
    }

    public void OnExit(Enemy enemy)
    {

    }
}

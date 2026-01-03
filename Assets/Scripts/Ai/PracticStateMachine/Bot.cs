using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Bot : MonoBehaviour
{
    public StateEnum InitialState;
    public Transform PlayerTransform;

    [HideInInspector] public StateMachine BotStateMachine;
    [HideInInspector] public NavMeshAgent BotNavMesh;

    private void Start()
    {
        BotNavMesh = GetComponent<NavMeshAgent>();

        BotStateMachine = new StateMachine(this);
        BotStateMachine.RegistryState(new IdleState());
        BotStateMachine.RegistryState(new ChasePlayerState());
        BotStateMachine.ChangeState(InitialState);
    }

    private void Update()
    {
        BotStateMachine.Update();
    }
}

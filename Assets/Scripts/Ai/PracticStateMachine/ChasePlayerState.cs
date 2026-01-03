using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChasePlayerState : IState
{
    public StateEnum GetID() => StateEnum.ChasePlayer;

    public void EnterState(Bot bot)
    {
    }

    public void UpdateState(Bot bot)
    {
        var distanceToPlayer = Vector3.Distance(bot.PlayerTransform.position, bot.transform.position);
        if (distanceToPlayer > 2f)
            bot.BotNavMesh.destination = bot.PlayerTransform.position;
        else
            bot.BotStateMachine.ChangeState(StateEnum.Idle);
    }

    public void ExitState(Bot bot)
    {
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats
{
    public static int statMin = 0;
    public static int statMax = 10;

    private int attackStat;

    public Stats(int attackStackAmount)
    {
        SetAttackStatAmount(attackStackAmount);
    }

    public void SetAttackStatAmount(int attackStatAmount)
    {
        attackStat = Mathf.Clamp(attackStatAmount, statMin, statMax);
    }

    public int GetAttackStatAmount()
    {
        ;return attackStat;
    }

    public float GetAttackStatAmountNormalized()
    {
        return (float)attackStat / statMax;
    }
}

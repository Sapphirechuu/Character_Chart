using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Testing : MonoBehaviour
{
    [SerializeField] private UIStatsRadarChart uIStatsRadarChart;

    // Start is called before the first frame update
    void Start()
    {
        Stats stats = new Stats(5);
        Debug.Log(stats.GetAttackStatAmount());

        uIStatsRadarChart.SetStats(stats);
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DefaultRuleArguments
{
    public static float mutationRate = 1f;
    public static int targetEnemies = 4;
    public static int maxCoins = 6;
    public static int maxTraps = 4;
    public static int populationSize = 100;
    public static List<int[]> checkpoints = new List<int[]>()
    {
        new int[2] {7, 3},
    };

    public static int evaluationMode = 2;

    public static float[] ruleWeights = new float[10]
    {
        1f,
        1f,
        1f,
        1f,
        1f,
        1f,
        1f,
        1f,
        1f,
        20f
    };
    
}

﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using UnityEngine;

public class InitRandomPopulation {

    CreateRoom cr = new CreateRoom();
    GeneratorRules gr = new GeneratorRules(DefaultRuleArguments.mutationRate,
                                           DefaultRuleArguments.targetEnemies,
                                           DefaultRuleArguments.maxCoins,
                                           DefaultRuleArguments.maxTraps);

    public Room[] population;
    public Room bestRoom;

    public InitRandomPopulation(EvaluateRoom evaluateRoom)
    {
        population = Generate(evaluateRoom);
    }

    /// <summary>
    /// Method that generates the initial set of rooms to be evolved
    /// </summary>
    /// <returns>the set of rooms</returns>
    public Room[] Generate(EvaluateRoom evaluateRoom)
    {
        Room[] initMap = new Room[gr.GetInitRandomPopulationSize()];

        for (int i = 0; i < initMap.Length; i++)
        {
            initMap[i] = cr.Generate(evaluateRoom);
            // check the best map
            SetBestRoom(initMap[i]);
        }
       
        return initMap;
    }

    public void SetBestRoom(Room toCheck)
    {
        if(bestRoom == null)
        {
            bestRoom = toCheck;
            return;
        } else if(bestRoom.Fitness < toCheck.Fitness)
        {
            bestRoom = toCheck;
            return;
        }
    }

}

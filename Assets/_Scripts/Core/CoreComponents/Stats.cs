﻿using System;
using Bardent.CoreSystem.StatsSystem;
using UnityEngine;

namespace Bardent.CoreSystem
{
    public class Stats : CoreComponent
    {
        [field: SerializeField] public Stat Health { get; private set; }
        [field: SerializeField] public Stat Poise { get; private set; }
        protected override void Awake()
        {
            base.Awake();
            
            Health.Init();
            Poise.Init();
        }
    }
}
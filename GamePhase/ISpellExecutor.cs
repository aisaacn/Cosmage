﻿using CosmageV2.PlayerInteraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CosmageV2.GamePhase
{
    public interface ISpellExecutor
    {
        void ExecuteSpell(Spell spell);
    }
}
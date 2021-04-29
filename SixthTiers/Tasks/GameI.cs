﻿using System;
using System.Collections;
using System.Collections.Generic;
using Assets.Scripts.Models;
using Assets.Scripts.Models.Audio;
using Assets.Scripts.Models.Map;
using Assets.Scripts.Models.Profile;
using Assets.Scripts.Models.Skins;
using Assets.Scripts.Models.Skins.Behaviors;
using Assets.Scripts.Models.Towers;
using Assets.Scripts.Models.Towers.Behaviors;
using Assets.Scripts.Models.Towers.Mods;
using Assets.Scripts.Models.Towers.Upgrades;
using Assets.Scripts.Simulation.Bloons;
using Assets.Scripts.Simulation.Towers;
using Assets.Scripts.Simulation.Towers.Weapons;
using Assets.Scripts.Utils;
using Harmony;
using MelonLoader;
using SixthTiers.Resources;
using SixthTiers.Utils;
using UnhollowerBaseLib;
using UnhollowerRuntimeLib;
using UnityEngine;
using UnityEngine.AddressableAssets.ResourceLocators;
using UnityEngine.ResourceManagement.ResourceLocations;
using IList = Il2CppSystem.Collections.IList;

namespace SixthTiers.Tasks {
    public class GameI {
        [HarmonyPatch(typeof(GameModelLoader), nameof(GameModelLoader.Load))]
        public static class Loaded {
            [HarmonyPostfix]
            public static void Postfix(ref GameModel __result) {
                for (var i = 0; i < SixthTier.towers.Count; i++) SixthTier.towers[i].gameLoad(__result);
            }
        }
    }
}










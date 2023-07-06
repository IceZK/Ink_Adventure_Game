using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    [CreateAssetMenu(fileName = "HealthStatusData", menuName = "StatusObjects/Health", order = 1)]
    public class Character_Stat_OS : ScriptableObject
    {
        public string charName = "name";
        //base stat
        [Header("base stat")]
        public int baseMaxHp = 0;
        public float baseMaxRL = 0;
        public float baseMaxOxy = 0;
        public int baseMaxCapacity = 0;

        public int baseHp = 0;
        public int baseDamage = 0;
        public float baseRL = 0;
        public float baseOxy = 0;
        public int baseCapacity = 0;


        //Modifier stat
        [Header("Modifier stat")]
        public int MaxHp = 0;
        public float MaxRL = 0;
        public float MaxOxy = 0;
        public int Hp = 0;
        public int Damage = 0;
        public int RL = 0;
        public int Oxy = 0;
        public int Capacity = 0;
    }
}


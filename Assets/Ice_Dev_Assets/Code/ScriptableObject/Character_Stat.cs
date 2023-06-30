using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    [CreateAssetMenu(fileName = "HealthStatusData", menuName = "StatusObjects/Health", order = 1)]
    public class Character_Stat : ScriptableObject
    {
        public string charName = "name";
        //base stat
        [Header("base stat")]
        public int baseMaxHp = 0;
        public int baseMaxRL = 0;
        public int baseMaxOxy = 0;
        public int baseMaxCapacity = 0;

        public int baseHp = 0;
        public int baseDamage = 0;
        public int baseRL = 0;
        public int baseOxy = 0;
        public int baseCapacity = 0;


        //Modifier stat
        [Header("Modifier stat")]
        public int MaxHp = 0;
        public int MaxRL = 0;
        public int MaxOxy = 0;
        public int Hp = 0;
        public int Damage = 0;
        public int RL = 0;
        public int Oxy = 0;
        public int Capacity = 0;
    }
}


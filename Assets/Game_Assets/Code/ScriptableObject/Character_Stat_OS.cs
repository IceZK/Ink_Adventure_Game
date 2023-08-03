using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    [CreateAssetMenu(fileName = "HealthStatusData", menuName = "StatusObjects/Status", order = 1)]
    public class Character_Stat_OS : ScriptableObject
    {
        public string charName = "name";
        //base stat
        [Header("base stat")]
        
        public float baseMaxCurse = 0;
        public float baseMaxInk = 0;
        public int baseBagCap = 0;

        
        public int baseDamage = 0;
        public float baseCurse = 0;
        public float baseInk = 0;
        public int baseBag = 0;


        //Modifier stat
        [Header("Modifier stat")]
        
        public float MaxCurse = 0;
        public float MaxInk = 0;
        public int Damage = 0;
        public int Curse = 0;
        public int Ink = 0;
        public int Bag = 0;
    }
}


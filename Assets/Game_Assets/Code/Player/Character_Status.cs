using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    public class Character_Status : MonoBehaviour
    {
        public Character_Stat_OS StatOS;

        public string charName = "name";
        //base stat
        [Header("base stat")]
        public int MaxHp = 0;
        public float MaxCurse = 0;
        public float MaxInk = 0;
        public int BagCap = 0;

        public int CurrentHp = 0;
        public int CurrentDamage = 0;
        public float CurrentCurse = 0;
        public float CurrentInk = 0;
        public int CurrentBag = 0;


        //Modifier stat
        [Header("Modifier stat")]
        public int ModMaxHp = 0;
        public float ModMaxCurse = 0;
        public float ModMaxInk = 0;
        public int ModDamage = 0;
        public int ModBag = 0;

        void Start()
        {
            charName = StatOS.charName;
            MaxHp = StatOS.baseMaxHp;
            MaxCurse = StatOS.baseMaxCurse;
            MaxInk = StatOS.baseMaxInk;
            BagCap = StatOS.baseBagCap;

            CurrentHp = StatOS.baseHp;
            CurrentDamage = StatOS.baseDamage;
            CurrentCurse = StatOS.baseCurse;
            CurrentInk = StatOS.baseInk;
            CurrentBag = StatOS.baseBag;

            ModMaxHp = StatOS.MaxHp;
            ModMaxCurse = StatOS.MaxCurse;
            ModMaxInk = StatOS.MaxInk;
            ModDamage = StatOS.Damage;
            ModBag = StatOS.Bag;
        }
        void Update()
        {
            MaxHp += ModMaxHp;
            MaxCurse += ModMaxCurse;
            MaxInk += ModMaxInk;
            CurrentDamage += ModDamage;
            BagCap += ModBag;
        }
       
    }
}


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
        public float MaxRL = 0;
        public float MaxOxy = 0;
        public int MaxCapacity = 0;

        public int CurrentHp = 0;
        public int CurrentDamage = 0;
        public float CurrentRL = 0;
        public float CurrentOxy = 0;
        public int CurrentCapacity = 0;


        //Modifier stat
        [Header("Modifier stat")]
        public int ModMaxHp = 0;
        public float ModMaxRL = 0;
        public float ModMaxOxy = 0;
        public int ModDamage = 0;
        public int ModCapacity = 0;

        void Start()
        {
            charName = StatOS.charName;
            MaxHp = StatOS.baseMaxHp;
            MaxRL = StatOS.baseMaxRL;
            MaxOxy = StatOS.baseMaxOxy;
            MaxCapacity = StatOS.baseMaxCapacity;

            CurrentHp = StatOS.baseHp;
            CurrentDamage = StatOS.baseDamage;
            CurrentRL = StatOS.baseRL;
            CurrentOxy = StatOS.baseOxy;
            CurrentCapacity = StatOS.baseCapacity;

            ModMaxHp = StatOS.MaxHp;
            ModMaxRL = StatOS.MaxRL;
            ModMaxOxy = StatOS.MaxOxy;
            ModDamage = StatOS.Damage;
            ModCapacity = StatOS.Capacity;
        }
        void Update()
        {
            MaxHp += ModMaxHp;
            MaxRL += ModMaxRL;
            MaxOxy += ModMaxOxy;
            CurrentDamage += ModDamage;
            MaxCapacity += ModCapacity;
        }
       
    }
}


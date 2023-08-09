using IceZK_DEV;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    public class Enmy_Status : MonoBehaviour
    {
        public Enemy_StatusSO StatusSO; 
        //base stat
        [Header("base stat")]


        public float baseMaxInk = 0;
        public int baseDamage = 0;
        public float baseInk = 0;
        public float EXP = 0;
        public int monMat = 0;
        public int minDrop = 0;
        public int maxDrop = 0;
        void Start()
        {
            this.gameObject.name = StatusSO.charName;

            baseMaxInk = StatusSO.baseMaxInk;
            baseDamage = StatusSO.baseDamage;
            baseInk = StatusSO.baseInk;
            EXP = StatusSO.EXP;
            monMat = StatusSO.monMat;
            minDrop = StatusSO.minDrop;
            maxDrop = StatusSO.maxDrop;

            monMat = Random.Range(minDrop, maxDrop);
        }

    }
    
}

    


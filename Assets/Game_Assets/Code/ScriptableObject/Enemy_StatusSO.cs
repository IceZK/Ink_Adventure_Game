using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    [CreateAssetMenu(fileName = "Enemy_Status", menuName = "StatusObjects/Status", order = 1)]
    public class Enemy_StatusSO : ScriptableObject
    {

        // Start is called before the first frame update
        public string charName = "name";
        //base stat

        [Header("base stat")]
        public float baseMaxInk = 0;
        public int baseDamage = 0;
        public float baseInk = 0;
        public float EXP = 0;

        public int monMat = 0;
        public int minDrop = 0;
        public int maxDrop = 0;

    }
}



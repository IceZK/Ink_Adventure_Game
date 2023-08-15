using IceZK_DEV;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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
        private void OnTriggerEnter(Collider other)
        {
            if (other.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("CombatScene", LoadSceneMode.Additive);

                Character_Status_Manager.Enemy_baseMaxInk = this.baseMaxInk;
                Character_Status_Manager.Enemy_baseDamage = this.baseDamage;
                Character_Status_Manager.Enemy_baseInk = this.baseInk;
                Character_Status_Manager.Enemy_EXP = this.EXP;
                //valueDrop
            }
        }

    }
    
}

    


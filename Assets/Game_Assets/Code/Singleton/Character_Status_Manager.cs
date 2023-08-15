using System.Collections;
using UnityEngine;

namespace IceZK_DEV
{
    public class Character_Status_Manager : MonoBehaviour
    {
        public static Character_Status_Manager CSM_instance;

        
        //base stat
        [Header("Player stat")]

        public static float player_baseMaxCurse = 0;
        public static float player_baseMaxInk = 0;
        public static int player_baseBagCap = 0;


        public static int player_baseDamage = 0;
        public static float player_baseCurse = 0;
        public static float player_baseInk = 0;
        public static float player_InkTemp = 0;
        public static int player_baseBag = 0;

        public static int player_EXP = 0;
        public static int player_LV = 0;

        [Header("Enemy stat")]
        public static float Enemy_baseMaxInk = 0;
        public static int Enemy_baseDamage = 0;
        public static float Enemy_baseInk = 0;
        public static float Enemy_EXP = 0;
        // Use this for initialization

        private void Awake()
        {
            // if the singleton hasn't been initialized yet
            if (CSM_instance != null && CSM_instance != this)
            {
                Destroy(this.gameObject);

            }
            else
            {
                DontDestroyOnLoad(this.gameObject);
                CSM_instance = this;


            }
        }
        
        public void Called_Enemy()
        {

        }
    }
}
using IceZK_DEV;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Kagerou
{
    public class FightingSystem : MonoBehaviour
    {
        [SerializeField] protected int phase = 0;
        [SerializeField] protected int playerAction = 0;
        [SerializeField] protected int enemyAction = 0;
        public static string phase_text;
        public Button action_1;
        public Button action_2;
        public Button action_3;
        public Button action_4;

        private float player_baseMaxInk;
        private float player_baseInk;
        private float player_baseDamage;
        private float enemy_baseMaxInk;
        private float enemy_baseInk;
        private float enemy_baseDamage;
        // Start is called before the first frame update
        void Start()
        {
            player_baseMaxInk = Character_Status_Manager.player_baseMaxInk;
            player_baseInk = Character_Status_Manager.player_baseInk;
            player_baseDamage = Character_Status_Manager.player_baseDamage;
            enemy_baseMaxInk = Character_Status_Manager.enemy_baseMaxInk;
            enemy_baseInk = Character_Status_Manager.enemy_baseInk;
            enemy_baseDamage = Character_Status_Manager.enemy_baseDamage;
        }

        // Update is called once per frame
        void Update()
        {
            Debug.Log("Phase" + phase);
            Debug.Log(playerAction);
            Debug.Log(enemyAction);
            ActionPhase();
        }
        public void OnAction1Click()
        {
            playerAction = 1;
        }
        public void OnAction2Click()
        {
            playerAction = 2;
        }
        public void OnAction3Click()
        {
            playerAction = 3;
        }
        public void OnAction4Click()
        {
            playerAction = 4;
        }
     
        private void ActionPhase()
        {
            switch(phase) 
            {
                case 0:AttackSelectPhase();
                    break;
                case 1:AttackAnimatePhase();
                    break;
                case 2:DefenseSelectPhase();
                    break;
                case 3:DefenseAnimatePhase();
                    break;
            }
        }
        private void AttackSelectPhase()
        {
            if(playerAction > 0)
            {
                phase++;
                playerAction = 0;
            }
            phase_text = "Attack Select Phase";
        }
        private void AttackAnimatePhase()
        {
            phase++;
            phase_text = "Attack Animate Phase";
        }
        private void DefenseSelectPhase()
        {
            if (playerAction > 0)
            {
                phase++;
                playerAction = 0;
            }
            phase_text = "Defense Select Phase";
        }
        private void DefenseAnimatePhase()
        {
            phase = 0;
            phase_text = "Defense Animate Phase";
        }
    }
}


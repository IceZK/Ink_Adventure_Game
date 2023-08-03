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
        public Button action_1;
        public Button action_2;
        public Button action_3;
        public Button action_4;
        // Start is called before the first frame update
        void Start()
        {
            
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
            Debug.Log("AttackSelectPhase");
            if(playerAction > 0)
            {
                phase++;
                playerAction = 0;
            }
        }
        private void AttackAnimatePhase()
        {
            Debug.Log("AttackAnimationPhase");
            phase++;
        }
        private void DefenseSelectPhase()
        {
            Debug.Log("DefenseSelectPhase");
            if (playerAction > 0)
            {
                phase++;
                playerAction = 0;
            }
        }
        private void DefenseAnimatePhase()
        {
            Debug.Log("DefenseAnimationPhase");
            phase = 0;
        }
    }
}


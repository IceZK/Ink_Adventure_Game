using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace Kagerou
{
    public class FightingSystem : MonoBehaviour
    {
        [SerializeField] protected int phase = 0;
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
            Debug.Log(phase);
        }
        public void OnClick()
        {
            ActionPhase();
            Debug.Log("Click");
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
            phase++;
        }
        private void AttackAnimatePhase()
        {
            Debug.Log("AttackAnimationPhase");
            phase++;
        }
        private void DefenseSelectPhase()
        {
            Debug.Log("DefenseSelectPhase");
            phase++;
        }
        private void DefenseAnimatePhase()
        {
            Debug.Log("DefenseAnimationPhase");
            phase++;
        }
    }
}


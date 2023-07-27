using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Kagerou
{
    public class FightingSystem : MonoBehaviour
    {
        private int phase = 0;
        // Start is called before the first frame update
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            phase = PhaseCounter();
            Debug.Log(phase);
        }
            
        private int PhaseCounter()
        {
            int turn = phase;
            if (turn < 4) turn++;
            else turn = 0;
            return turn;
        }
    }
}


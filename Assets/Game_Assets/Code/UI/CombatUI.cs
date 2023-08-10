using IceZK_DEV;
using System.Collections;
using System.Collections.Generic;
using System.Net.Sockets;
using UnityEngine;
namespace Kagerou
{
    public class CombatUI : MonoBehaviour
    {
        Character_Status CS;
        // Start is called before the first frame update
        void Start()
        {
            CS = GetComponent<Character_Status>();
        }

        // Update is called once per frame
        void Update()
        {
            float ink = CS.CurrentInk;
        }
    }
}


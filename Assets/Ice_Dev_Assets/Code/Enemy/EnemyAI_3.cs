using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

namespace Scprite.Enmey.EnemyAI
{
    public class EnemyAI_3 : MonoBehaviour
    {
        public NavMeshAgent agent;
        Transform Player;

        private void Awake()
        {
            Player = GameObject.FindWithTag("Player").transform;
        }
        void Start()
        {

        }
        // Update is called once per frame
        private void Update()
        {

            agent.SetDestination(Player.position);
        }
    }
}


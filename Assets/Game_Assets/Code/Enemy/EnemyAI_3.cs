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
        public SpriteRenderer sr;

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
            if (this.transform.position.x > Player.position.x)
            {
                sr.flipX = true;
            }
            else if (this.transform.position.x < Player.position.x)
            {
                sr.flipX = false;
            }
        }
    }
}


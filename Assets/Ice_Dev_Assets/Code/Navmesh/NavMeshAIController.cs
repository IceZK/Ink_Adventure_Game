using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    [RequireComponent(typeof(UnityEngine.AI.NavMeshAgent))]
    //[RequireComponent(typeof(ThirdPersonControllerAI))]
    public class NavMeshAIController : MonoBehaviour
    {
        // Start is called before the first frame update
        [SerializeField] protected UnityEngine.AI.NavMeshAgent m_NavMeshAgent;

        [SerializeField] protected Transform m_Target = null;

        //[SerializeField] protected ThirdPersonControllerAI m_CharacterController;

        void Start()
        {
            m_NavMeshAgent = GetComponent<UnityEngine.AI.NavMeshAgent>();
            m_NavMeshAgent.updateRotation = true;
            m_NavMeshAgent.updatePosition = true;

            //m_CharacterController = GetComponent<ThirdPersonControllerAI>();
        }

        // Update is called once per frame
        void Update()
        {
            if (m_Target != null)
            {
                 m_NavMeshAgent.SetDestination(m_Target.position);
            }
           
            if (m_NavMeshAgent.remainingDistance > m_NavMeshAgent.stoppingDistance)
            {
                if (m_Target != null)
                {
                 //m_CharacterController.Move(m_Target.position);
                }
            }
            else
            {
                if (m_Target != null)
                {
                    //m_CharacterController.Move(Vector3.zero, 0);
                    m_Target = null;
                }
            }
        }
        public void SetTarget(Transform target)
        {
            m_Target = target;
        }
    
        public Vector3 GetTargetPosition()
        {
            return m_Target.position;
        }
    }
}


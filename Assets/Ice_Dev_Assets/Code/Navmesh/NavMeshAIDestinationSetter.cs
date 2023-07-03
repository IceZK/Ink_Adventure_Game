using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

namespace IceZK_DEV
{
    [RequireComponent(typeof(NavMeshAIController))]
    public class NavMeshAIDestinationSetter : MonoBehaviour
    {
        [SerializeField] protected NavMeshAIController m_NMAIController;

        [SerializeField] private float surfaceOffset = 0;

        public SpriteRenderer sr;
        void Start()
        {
            m_NMAIController = GetComponent<NavMeshAIController>();

        }

        // Update is called once per frame
        void Update()
        {
            Mouse mouse = Mouse.current;
            if (mouse.leftButton.wasPressedThisFrame)
            {
                RaycastHit hit;
                Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
                if (Physics.Raycast(ray, out hit) == true)
                {
                    GameObject pickedTarget = new GameObject();
                    pickedTarget.transform.position = hit.point + hit.normal *
                    surfaceOffset;
                    if (this.transform.position.x > pickedTarget.transform.position.x)
                    {
                        sr.flipX = true;
                    }
                    else if (this.transform.position.x < pickedTarget.transform.position.x)
                    {
                        sr.flipX = false;
                    }

                    m_NMAIController.SetTarget(pickedTarget.transform);

                    Destroy(pickedTarget, 0.2f);

                }
            }
        }
    }
}


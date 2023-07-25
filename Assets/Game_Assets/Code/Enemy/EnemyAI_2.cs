using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyAI_2 : MonoBehaviour
{
    public string targetTag = "Player";
    public Agent agentData;
    

    void Start()
    {
        agentData = GetComponentInParent<Agent>();
    }

    // Update is called once per frame
    private void OnTriggerStay(Collider other)
    {
        GameObject target = other.gameObject;
        string tag = target.tag;
        if(tag.Equals(targetTag) == false)
        {
            return;
        }
        Vector3 agentPosition = gameObject.transform.position;
        Vector3 targetPosition = target.transform.position;
        Vector3 direction = targetPosition - agentPosition;

        Ray ray = new Ray(agentPosition, direction.normalized);
        RaycastHit hit;
        Debug.DrawRay(agentPosition, direction);
        if (Physics.Raycast(ray, out hit, direction.magnitude))
        {
            if(hit.collider.gameObject.tag.Equals(target))
            {
                agentData.target = target;
                return;
            }
        }
        agentData.target = null;
    }

    private void OnTriggerExit(Collider other)
    {
        if(agentData.target!=null && other.gameObject == agentData.target)
        {
            agentData.target = null;
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableItem : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Yes");
    }
    private void OnTriggerEnter(Collider other)
    {
        Debug.Log("Yes");
    }
}

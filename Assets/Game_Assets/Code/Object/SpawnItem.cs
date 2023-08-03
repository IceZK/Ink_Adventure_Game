using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnItem : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Item;
    public int amount;
    Bounds area;
    
    void Start()
    {   
        for(int i = 0; i <= amount; i++)
        {
            //Instantiate(Item, new Vector3(0, 1, 0), Quaternion.identity);
            Instantiate(Item, new Vector3(Random.Range(-32, 40), 1, Random.Range(-20, 20)), Quaternion.identity);
        }
       
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

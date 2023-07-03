using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace IceZK_DEV
{
    public class PlayerTriggerWithITC : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            
            Item itc = other.GetComponent <Item>();
            
            var inventory = GetComponent <Inventory2>();
            
            if (itc != null)
            {


                switch (itc.type)
                {
                    case ItemType.Useable:
                        inventory.AddItem(itc.ItemName, 1);
                        break;
                    case ItemType.Material:
                        inventory.AddItem(itc.ItemName, 1);
                        break;
                    case ItemType.ITEM:
                        inventory.AddItem(itc.ItemName, 1);
                        break;

                }
                Debug.Log("Yes");
                Destroy(other.gameObject, 0);
                
            }




        }
    }
}
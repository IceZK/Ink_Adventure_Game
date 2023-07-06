using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace IceZK_DEV
{
    public class PlayerTriggerWithITC : MonoBehaviour
    {
        private InventoryManager inventoryManager;
        void Start()
        {
            inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
        }
        private void OnTriggerEnter(Collider other)
        {   
            Item item = other.GetComponent <Item>();

            //var inventory = GetComponent<InventoryManager>();
            

            if (item != null)
            {


                switch (item.type)
                {
                    case ItemType.Useable:
                        inventoryManager.AddItem(item.ItemName, item.amount, item.icon);
                        break;
                    case ItemType.Material:
                        inventoryManager.AddItem(item.ItemName, item.amount, item.icon);
                        break;
                    case ItemType.ITEM:
                        inventoryManager.AddItem(item.ItemName, item.amount, item.icon);
                        break;

                }
                Destroy(other.gameObject, 0);
                
            }




        }
    }
}
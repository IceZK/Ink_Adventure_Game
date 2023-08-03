using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace IceZK_DEV
{
    public class PlayerTriggerWithITC : MonoBehaviour
    {
        private InventoryManager inventoryManager;
        private float loottime;
        bool check;
        public int HugeAmount;
        //get component
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
                        Destroy(other.gameObject, 0);
                        break;
                    case ItemType.Material:
                        inventoryManager.AddItem(item.ItemName, item.amount, item.icon);
                        Destroy(other.gameObject, 0);
                        break;
                    case ItemType.ITEM:
                        inventoryManager.AddItem(item.ItemName, item.amount, item.icon);
                        Destroy(other.gameObject, 0);
                        break;
                    case ItemType.HugeMaterial:
                        //get component int
                        //code
                        if (Input.GetKeyDown("Loot") && check == false)
                        {
                            loottime = 3;
                            check = true;
                        }
                        else if (Input.GetKeyDown("Loot") && loottime <= 0 && check == true && HugeAmount <= 0)
                        {
                            inventoryManager.AddItem(item.ItemName, item.amount, item.icon);
                            check = false;
                        }
                        
                        break;

                }
                
                
            }




        }
    }
}
using UnityEngine;
using System.Diagnostics;
using IceZK_DEV;


namespace IceZK_DEV
{
    public class PlayerTriggerWithITC : MonoBehaviour
    {
        private void OnTriggerEnter(Collider other)
        {
            ItemTypeComponent itc = other.GetComponent <ItemTypeComponent >();
            
            var inventory = GetComponent <Inventory2>();
            
            
            

            if (itc != null)
            {
                switch (itc.Type)
                {
                    case ItemType.ITEM:
                        inventory.AddItem("ITEM",1);
                        break;
    
                }
            }

            Destroy(other.gameObject, 0);


        }
    }
}
using UnityEngine;

namespace IceZK_DEV
{
    public class ItemTriggerWithPlayerHandler : MonoBehaviour
    {
        protected virtual void OnTriggerEnter(Collider other)
        {
            if (other.CompareTag("Player")){ 
                if (gameObject.CompareTag("Diamond"))
                { 
                    ProcessTriggerWithDiamond();
                }else if (gameObject.CompareTag("Coin"))
                {
                    ProcessTriggerWithCoin();
                }
                
                //Get the Inventory component from the player
                var inventory = other.GetComponent <Inventory2>();
                
                //Add the collected item's tag name to the inventory
                inventory.AddItem(gameObject.tag,1);
                
                //Destroy itself
                Destroy(gameObject);
            }

        }

        protected virtual void ProcessTriggerWithDiamond()
        {
            
        }

        protected virtual void ProcessTriggerWithCoin()
        {
            
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    public class InventoryManager : MonoBehaviour
    {
        public GameObject InventoryMenu;
        private bool MenuActivated;
        public ItemSlot[] itemSlot;
        void Start()
        {

        }

        // Update is called once per frame
        void Update()
        {
            
            if (Input.GetButtonDown("Inventory") && MenuActivated)
            {
                Time.timeScale = 1;
                InventoryMenu.SetActive(false);
                MenuActivated = false;
                Debug.Log("Inventory Close");
            }
            else if (Input.GetButtonDown("Inventory") && !MenuActivated)
            {
                Time.timeScale = 0;
                InventoryMenu.SetActive(true);
                MenuActivated = true;
                Debug.Log("Inventory Close");
            }
        }

        public void AddItem(string itemName, int amount, Sprite itemSprite)
        {
            for (int i = 0; i < itemSlot.Length; i++)
            {
                if(itemSlot[i].isFull == false)
                {
                    itemSlot[i].AddItem(itemName, amount, itemSprite);
                    return;
                }
            }
        }

        public void DeselectedAllSlot()
        {
            for (int i = 0; i < itemSlot.Length; i++)
            {
                {
                    itemSlot[i].selctedShader.SetActive(false);
                    itemSlot[i].thisItemSelected = false;
                }
            }
        }
    }
}



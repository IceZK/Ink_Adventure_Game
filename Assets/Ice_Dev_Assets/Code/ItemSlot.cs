using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
namespace IceZK_DEV
{
    public class ItemSlot : MonoBehaviour, IPointerClickHandler
    {

        [Header("Item Data")]
        public string itemName;
        public int quantity;
        public Sprite itemSprite;
        public bool isFull;


        [Header("Item Slot")]
        [SerializeField] private TMP_Text quantityText;
        [SerializeField] private Image itemImage;

        [Header("Selected Slot")]
        public GameObject selctedShader;
        public bool thisItemSelected;

        private InventoryManager inventoryManager;

        private void Start()
        {
            inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
        }
        public void AddItem(string itemName, int quantity, Sprite itemSprite)
        {
            this.itemName = itemName;
            this.quantity = quantity;
            this.itemSprite = itemSprite;
            isFull = true;

            quantityText.text = quantity.ToString();
            quantityText.enabled = true;
            itemImage.sprite = itemSprite;
        }

        

        public void OnPointerClick(PointerEventData eventData)
        {
            if (eventData.button == PointerEventData.InputButton.Left)
            {
                OnLeftClick();
            }
            if (eventData.button == PointerEventData.InputButton.Right)
            {
                OnRightClick();
            }
        }

        public void OnLeftClick()
        {
            //Select item
            inventoryManager.DeselectedAllSlot();
            selctedShader.SetActive(true);
            thisItemSelected = true;
            
        }
        public void OnRightClick()
        {
            //Desrcibe item
        }
    }
}


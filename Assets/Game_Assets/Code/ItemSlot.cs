using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using UnityEngine.EventSystems;
namespace IceZK_DEV
{
    public class ItemSlot : MonoBehaviour, IPointerClickHandler, IDropHandler
    {

        [Header("Item Data")]
        public string itemName;
        public int amount;
        public Sprite itemSprite;
        public bool isFull;


        [Header("UI Slot")]
        [SerializeField] private TMP_Text amountText;
        [SerializeField] private Image itemImage;

        [Header("Selected Slot")]
        public GameObject selctedShader;
        public bool thisItemSelected;

        private InventoryManager inventoryManager;

        private void Start()
        {
            inventoryManager = GameObject.Find("InventoryCanvas").GetComponent<InventoryManager>();
        }
        public void AddItem(string itemName, int amount, Sprite itemSprite)
        {
            this.itemName = itemName;
            this.amount = amount;
            this.itemSprite = itemSprite;
            isFull = true;

            amountText.text = amount.ToString();
            amountText.enabled = true;
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

        public void OnDrop(PointerEventData eventData)
        {
            if(eventData.pointerDrag != null)
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().anchoredPosition;
            }
        }
    }
}


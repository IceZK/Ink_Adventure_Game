using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Ice_DEV
{
    public class MenuButton : MonoBehaviour
    {
        public MenuButtonController menuButtonController;
        public Animator animator;
        public int thisIndex;
        [SerializeField] GameObject menuPanelToOpen;

        [Header("Equip Assignment")]
        public bool isEquipmentAssigned = false;
        public EquipType equipType;
        public Item equipItem;
        public ItemAction action;

        void Update()
        {
            if (menuButtonController.index == thisIndex)
            {
                animator.SetBool("selected", true);
                if (menuButtonController.isPressConfirm)
                {
                    animator.SetBool("pressed", true);
                    if (menuPanelToOpen != null)
                    {
                        if (isEquipmentAssigned)
                        {

                            menuPanelToOpen.gameObject.GetComponent<MenuButtonItemMenuController>().isEquipmentType = true;
                            menuPanelToOpen.gameObject.GetComponent<MenuButtonItemMenuController>().equipSort = equipType;
                        }

                        menuButtonController.gameObject.SetActive(false);
                        menuPanelToOpen.SetActive(true);
                    }
                }
                else if (animator.GetBool("pressed"))
                {
                    animator.SetBool("pressed", false);
                }
            }
            else
            {
                animator.SetBool("selected", false);
            }
        }
        public void OnEnable()
        {
            if (isEquipmentAssigned)
            {
                EquipmentManager.instance.onEquipmentChangedCallback += UpdateItemName;
                UpdateItemName();
            }
        }

        public void OnDisable()
        {
            if (isEquipmentAssigned)
            {
                EquipmentManager.instance.onEquipmentChangedCallback -= UpdateItemName;
            }
        }

        void UpdateItemName()
        {
            if (isEquipmentAssigned)
            {
                if (EquipmentManager.instance.currentEquipment[(int)equipType] != null)
                {
                    string equippedName = EquipmentManager.instance.currentEquipment[(int)equipType].name;
                    transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = equippedName;
                }
                else
                {
                    transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = "Empty";
                }
            }
        }
    }
}


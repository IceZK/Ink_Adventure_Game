using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

namespace Ice_DEV
{
    public class MenuButtonItemMenuController : MenuButtonController
    {
        [SerializeField] GameObject menuItemPrefab;
        public bool isEquipmentType = false;
        public EquipType equipSort;

        public override void OnEnable()
        {
            Dictionary<Item, int> inventory = new Dictionary<Item, int>();
            if (isEquipmentType)
            {
                foreach (Item item in Inventory.instance.items)
                {
                    if (item.type == ItemType.equipment)
                    {
                        Equipment equipment = (Equipment)item;

                        if (equipment.equipType == equipSort)
                        {
                            if (inventory.ContainsKey(item))
                            {
                                inventory[item] += 1;
                            }
                            else
                            {
                                inventory.Add(item, 1);
                            }
                        }
                    }
                }
            }
            else
            {
                foreach (Item item in Inventory.instance.items)
                {
                    if (inventory.ContainsKey(item))
                    {
                        inventory[item] += 1;
                    }
                    else
                    {
                        inventory.Add(item, 1);
                    }
                }
            }

            maxIndex = inventory.Count - 1;

            int index = 0;
            foreach (KeyValuePair<Item, int> entry in inventory)
            {
                if (menuItemPrefab != null)
                {
                    GameObject gameObject = Instantiate(menuItemPrefab, Vector3.zero, Quaternion.identity, this.transform) as GameObject;
                    gameObject.GetComponent<MenuButton>().menuButtonController = this;
                    gameObject.GetComponent<MenuButton>().thisIndex = index;
                    gameObject.GetComponent<MenuButton>().animator = gameObject.GetComponent<Animator>();
                    gameObject.transform.GetChild(1).GetComponent<TextMeshProUGUI>().text = entry.Key.name;
                    gameObject.transform.GetChild(3).GetComponent<TextMeshProUGUI>().text = entry.Value.ToString();
                    gameObject.GetComponent<MenuButton>().equipItem = entry.Key;
                    gameObject.GetComponent<MenuButton>().action = ItemAction.EQUIP;
                    index++;
                }
            }
        }


    }
}


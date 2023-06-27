using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ice_DEV
{
    public enum EquipType { MASK, ARMOR, WEAPON, BAG}

    [CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Equipment")]
    public class Equipment : Item
    {
        public EquipType equipType;

        public int HpModifier;
        public int DamageModifier;
        public int RLModifier;
        public int OxyModifier;
        public int CapacityModifier;

        public override void Use()
        {
            base.Use();
            EquipmentManager.instance.Equip(this);
            Inventory.instance.RemoveItem(this);
        }
    }
}



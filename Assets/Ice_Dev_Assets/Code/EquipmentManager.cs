using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ice_DEV
{
    public class EquipmentManager : MonoBehaviour
    {
        #region Singleton
        public static EquipmentManager instance;

        void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this);
            }
            else
            {
                Destroy(this.gameObject);
            }
        }
        #endregion Singleton

        public Equipment[] currentEquipment;

        public delegate void OnEquipmentChangedCallback();
        public OnEquipmentChangedCallback onEquipmentChangedCallback;

        private void Start()
        {
            int numSlots = System.Enum.GetNames(typeof(EquipType)).Length;
            currentEquipment = new Equipment[numSlots];
        }

        public void Equip(Equipment newItem)
        {
            int equipSlot = (int)newItem.equipType;

            Equipment oldItem = null;

            if (currentEquipment[equipSlot] != null)
            {
                oldItem = currentEquipment[equipSlot];
                Inventory.instance.AddItem(oldItem);
            }

            currentEquipment[equipSlot] = newItem;

            StatusManager.instance.UpdateCharacterStatus(newItem, oldItem);

            onEquipmentChangedCallback.Invoke();
        }
    }
}


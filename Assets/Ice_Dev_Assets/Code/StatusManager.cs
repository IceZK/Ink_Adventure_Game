using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ice_DEV
{
    public class StatusManager : MonoBehaviour
    {
        public Character_Stat playerStatus;

        public delegate void OnStatusChangedCallback();
        public OnStatusChangedCallback onStatusChangedCallback;

        #region Singleton
        public static StatusManager instance;

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

        #endregion

        public void UpdateCharacterStatus(Equipment newItem, Equipment oldItem)
        {
            if (oldItem != null)
            {
                playerStatus.Hp -= oldItem.HpModifier;
                playerStatus.Damage -= oldItem.DamageModifier;
                playerStatus.RL -= oldItem.RLModifier;
                playerStatus.Oxy -= oldItem.OxyModifier;
                playerStatus.Capacity -= oldItem.CapacityModifier;
            }
            playerStatus.Hp = playerStatus.baseMaxHp + newItem.HpModifier;
            playerStatus.Damage = playerStatus.baseDamage + newItem.DamageModifier;
            playerStatus.RL = playerStatus.baseMaxRL + newItem.RLModifier;
            playerStatus.Oxy = playerStatus.baseMaxOxy + newItem.OxyModifier;
            playerStatus.Capacity = playerStatus.baseMaxCapacity + newItem.CapacityModifier;

            onStatusChangedCallback.Invoke();
        }
        
    }
}



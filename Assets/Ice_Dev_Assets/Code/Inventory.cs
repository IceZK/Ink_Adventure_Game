using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ice_DEV
{
    public enum ItemAction { USE, EQUIP, DROP }

    public class Inventory : MonoBehaviour
    {
        public List<Item> items = new List<Item>();

        public delegate void OnItemChanged();
        public OnItemChanged onItemChangedCallback;

        #region Singleton
        public static Inventory instance;

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

        public void AddItem(Item item)
        {
            items.Add(item);
            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }

        public void RemoveItem(Item item)
        {
            items.Remove(item);
            if (onItemChangedCallback != null)
                onItemChangedCallback.Invoke();
        }
    }
}


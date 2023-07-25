using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    public class Item : MonoBehaviour
    {
        //ดึงค่าจากSO
        public ItemSO m_ItemSO;
        //ดึงค่าenum
        protected ItemType m_ItemType;

        public string ItemName;
        public Sprite icon;
        public ItemType type;
        public int amount;
        private int amountToChageMaxStat;
        private int amountToChangeStat;



        // Update is called once per frame

        private void Start()
        {
            ItemName = m_ItemSO.ItemName;
            icon = m_ItemSO.icon;
            type = m_ItemSO.type;
            amount = m_ItemSO.amount;
            this.gameObject.name = m_ItemSO.ItemName;
        }
        void update()
        {
             
            if (type == ItemType.Useable)
            {
                UseableItem();

            }
            else if (type == ItemType.Material)
            {
                MaterialItem();
            }
        }
        private void UseableItem()
        {

        }
        private void MaterialItem()
        {

        }
    }
}


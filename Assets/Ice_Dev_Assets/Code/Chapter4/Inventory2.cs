using UnityEngine;
using System;
using System.Collections.Generic;


namespace IceZK_DEV
{
    public class Inventory2 : MonoBehaviour
    {
        [SerializeField] protected List<string> m_ItemInventory = new();
        protected Dictionary<string,int> m_DictItemCount = new();

        public void AddItem(string itemName, int amount)
        {
            m_ItemInventory.Add(itemName);
            
            if (m_DictItemCount.ContainsKey(itemName))
            {
                m_DictItemCount[itemName] += amount;
            }
            else
            {
                m_DictItemCount.Add(itemName ,1);
            }
        }

        private void OnGUI()
        {
            DrawItemInventory();
            DrawItemCount();
        }

        private void DrawItemInventory()
        {
            int y = 0;
            int ySpacing = 15;
            int height = 20;
            GUI.color = Color.black;
            foreach (string s in m_ItemInventory)
            {
                GUI.Label(new Rect(5,y+=ySpacing ,150,height),s);

            }
        }

        private void DrawItemCount()
        {
            int y = 0;
            int ySpacing = 15;
            int height = 20;
            GUI.color = Color.black;
            foreach (KeyValuePair<string, int> kvp in m_DictItemCount)
            {
                GUI.Label(new Rect(300,y+=ySpacing ,150,height), kvp.Key + " : " + kvp.Value);
            }
        }

    }
}
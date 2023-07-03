using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    public enum ItemType {Useable, Material, ITEM }

    [CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item", order = 1)]

    public class ItemSO : ScriptableObject
    {

        new public string name = "New Item";
        public Sprite icon;
        public ItemType type;
        public int amountToChageMaxStat;

        public int amountToChangeStat;

        public void UseItem()
        {

        }
        public enum MaxStatToChange
        {
            none, MaxHp, MaxOxy, MaxRL
        };

        public enum CurrentStatToChange
        {
            none, Hp, Oxy, RL, Damage
        };

    }
}


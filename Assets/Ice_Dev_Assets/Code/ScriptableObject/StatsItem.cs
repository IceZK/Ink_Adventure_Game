using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Ice_DEV
{
    [CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Stats Item", order = 1)]
    public class StatsItem : Item
    {
        public int potency;

        public override void Use()
        {
            base.Use();
            Debug.Log("Using Item " + name + " with potency of " + potency);
        }
    }
}


using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace IceZK_DEV
{
    public class ItemTypeComponent : MonoBehaviour
    {
        [SerializeField] 
        protected ItemType m_ItemType;

        public ItemType Type
        {
            get
            {
                return m_ItemType;
            }
            set
            {
                m_ItemType = value;
            }
        }
    }
}


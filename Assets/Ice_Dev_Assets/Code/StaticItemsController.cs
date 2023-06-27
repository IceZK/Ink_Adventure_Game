using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using System;

namespace Ice_DEV
{
    public class StaticItemsController : MonoBehaviour
    {
        public List<TextMeshProUGUI> fields;

        private void Awake()
        {
            StatusManager.instance.onStatusChangedCallback += UpdateFields;
        }
        void UpdateFields()
        {
            Type fieldsType = typeof(Character_Stat);

            foreach (TextMeshProUGUI field in fields)
            {
                string value = fieldsType.GetField(field.name).GetValue(StatusManager.instance.playerStatus).ToString();
                field.text = value;
            }
        }
    }
}


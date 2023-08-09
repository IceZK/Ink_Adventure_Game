using System.Collections;
using UnityEngine;

namespace IceZK_DEV
{
    [CreateAssetMenu(fileName = "Resource", menuName = "Resource_SO", order = 1)]
    public class Resouce_SO : ScriptableObject
    {
        public string DropName = string.Empty;
        public int minDrop = 0;
        public int maxDrop = 0;
    }
}
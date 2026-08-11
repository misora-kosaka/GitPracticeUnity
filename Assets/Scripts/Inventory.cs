using System.Collections.Generic;
using UnityEngine;

namespace GitPracticeUnity
{
    public class Inventory : MonoBehaviour
    {
        [SerializeField] private int capacity = 8;
        private readonly List<string> items = new List<string>();

        public IReadOnlyList<string> Items => items;

        public bool Add(string itemName)
        {
            if (items.Count >= capacity)
            {
                return false;
            }

            items.Add(itemName);
            return true;
        }

        public bool Remove(string itemName)
        {
            return items.Remove(itemName);
        }
    }
}

using UnityEngine;

namespace StonesGaming
{
    public class Item : ScriptableObject
    {
        [Header ("Item Infomation")]
        public Sprite itemIcon;
        public string itemName;
    }
}
using UnityEngine;

namespace StonesGaming
{
    [CreateAssetMenu (menuName = "Items/Weapon Item")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;
    }
}
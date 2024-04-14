using UnityEngine;

namespace StonesGaming
{
    [CreateAssetMenu (menuName = "Items/Weapon Item")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;

        [Header("One Handed Attack Animations")]
        public string OH_Sword_Attack_1;
        public string OH_Sword_Attack_2;
    }
}
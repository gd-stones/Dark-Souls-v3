using UnityEngine;

namespace StonesGaming
{
    [CreateAssetMenu (menuName = "Items/Weapon Item")]
    public class WeaponItem : Item
    {
        public GameObject modelPrefab;
        public bool isUnarmed;

        [Header("Idle Animations")]
        public string right_hand_idle;
        public string left_hand_idle;

        [Header("Attack Animations")]
        public string oh_light_attack_01;
        public string oh_light_attack_02;
    }
}
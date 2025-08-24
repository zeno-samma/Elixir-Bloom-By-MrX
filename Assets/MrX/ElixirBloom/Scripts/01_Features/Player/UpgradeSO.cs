using UnityEngine;
using System.Collections.Generic;

namespace ElixirBloom
{
    [CreateAssetMenu(fileName = "UpgradeSO", menuName = "Survivor/UpgradeSO")]
    public class UpgradeSO : ScriptableObject
    {
        // Đây là danh sách chứa TẤT CẢ các nâng cấp trong game
        public List<UpgradeData> allUpgrades;
    }
}


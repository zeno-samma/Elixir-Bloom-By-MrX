using UnityEngine;

namespace MRX.ElixirBloom
{
    public class Block : MonoBehaviour
    {
        // Cần một Prefab ô thuốc đơn (ví dụ: một sprite hình vuông)
        public GameObject tilePrefab;

        // Trong hàm Initialize của Block.cs
        public void Initialize(BlockShapeSO shape)
        {
            foreach (Vector2Int tilePosition in shape.tiles)
            {
                // Tạo một Vector3 mới từ Vector2Int
                Vector3 worldPosition = new Vector3(tilePosition.x, tilePosition.y, 0);

                // Dùng vị trí mới này để tạo ô
                Instantiate(tilePrefab, worldPosition, Quaternion.identity, this.transform);
            }
        }
    }
}


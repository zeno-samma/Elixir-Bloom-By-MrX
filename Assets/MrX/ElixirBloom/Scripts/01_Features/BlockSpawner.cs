using System.Collections.Generic;
using UnityEngine;

namespace MRX.ElixirBloom
{
    public class BlockSpawner : MonoBehaviour
    {
        // Kéo các file .asset hình dạng vào list này trong Inspector
        public List<BlockShapeSO> allBlockShapes;
        public GameObject blockPrefab; // Kéo Prefab chứa script Block.cs vào đây

        void Start()
        {
            SpawnNewBlock();
        }

        public void SpawnNewBlock()
        {
            // 1. Chọn một hình dạng ngẫu nhiên từ "kho"
            BlockShapeSO randomShape = allBlockShapes[Random.Range(0, allBlockShapes.Count)];

            // 2. Tạo ra một khối thuốc mới từ Prefab
            GameObject newBlockObject = Instantiate(blockPrefab, transform.position, Quaternion.identity);

            // 3. Lấy script Block.cs từ nó
            Block blockScript = newBlockObject.GetComponent<Block>();

            // 4. Ra lệnh cho nó tự xây dựng theo hình dạng ngẫu nhiên
            blockScript.Initialize(randomShape);
        }
    }

}

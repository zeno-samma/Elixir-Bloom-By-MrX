using UnityEngine;

namespace MRX.ElixirBloom
{
    public class GridManager : MonoBehaviour
    {
        [SerializeField] private int width;
        [SerializeField] private int height;
        [SerializeField] private GameObject cellPrefab; // Một Prefab sprite ô vuông đơn giản

        // Mảng 2D để lưu trạng thái của lưới
        // (Chúng ta sẽ dùng nó nhiều sau này)
        private Transform[,] grid;

        void Start()
        {
            grid = new Transform[width, height];
            GenerateGrid();
        }

        void GenerateGrid()
        {
            // Tính toán độ lệch để căn giữa lưới
            float offsetX = (width - 1) / 2.0f;
            float offsetY = (height - 1) / 2.0f;

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    // Trừ đi độ lệch để có vị trí mới
                    Vector3 cellPosition = new Vector3(x - offsetX, y - offsetY, 0);

                    GameObject newCell = Instantiate(cellPrefab, cellPosition, Quaternion.identity);

                    newCell.name = $"Cell ({x}, {y})";
                    newCell.transform.parent = this.transform;
                    grid[x, y] = newCell.transform;
                }
            }
        }
    }
}

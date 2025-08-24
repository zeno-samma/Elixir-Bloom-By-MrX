using UnityEngine;
using System.Collections.Generic;

[CreateAssetMenu(fileName = "BlockShapeSO ", menuName = "ElixirBloom/Block Shape")]
public class BlockShapeSO : ScriptableObject
{
    // Danh sách vị trí tương đối của các ô con so với tâm của khối
    public List<Vector2Int> tiles;
}
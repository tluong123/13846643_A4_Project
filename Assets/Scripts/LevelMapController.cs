using UnityEngine;


public class LevelMapController : MonoBehaviour
{
    public GameObject[] tiles; // An array of prefabs for different tile types
    public Vector2 tileSize = new Vector2(0.1f, 0.1f); // Size of each tile



int[,] levelMap =
 {
 {1,2,2,2,2,2,2,2,2,2,2,2,2,7},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,4},
 {2,6,4,0,0,4,5,4,0,0,0,4,5,4},
 {2,5,3,4,4,3,5,3,4,4,4,3,5,3},
 {2,5,5,5,5,5,5,5,5,5,5,5,5,5},
 {2,5,3,4,4,3,5,3,3,5,3,4,4,4},
 {2,5,3,4,4,3,5,4,4,5,3,4,4,3},
 {2,5,5,5,5,5,5,4,4,5,5,5,5,4},
 {1,2,2,2,2,1,5,4,3,4,4,3,0,4},
 {0,0,0,0,0,2,5,4,3,4,4,3,0,3},
 {0,0,0,0,0,2,5,4,4,0,0,0,0,0},
 {0,0,0,0,0,2,5,4,4,0,3,4,4,0},
 {2,2,2,2,2,1,5,3,3,0,4,0,0,0},
 {0,0,0,0,0,0,5,0,0,0,4,0,0,0},
 };

    void Start()
    {
        GenerateLevel();
    }

void GenerateLevel()
{
    int numRows = levelMap.GetLength(0);
    int numColumns = levelMap.GetLength(1);

    for (int row = 0; row < numRows; row++)
    {
        for (int col = 0; col < numColumns; col++)
        {
            int tileValue = levelMap[row, col];

            // Ensure the tileValue is within the range of the 'tiles' array
            if (tileValue >= 0 && tileValue < tiles.Length)
            {
                Vector3 tilePosition = new Vector3(col * tileSize.x, -row * tileSize.y, 0f);
                GameObject tilePrefab = tiles[tileValue];

                // Instantiate the prefab at the calculated position
                GameObject tile = Instantiate(tilePrefab, tilePosition, Quaternion.identity);

                // Optionally, you can parent the tile to a container for organization
                // tile.transform.parent = transform;

                // Check if you want to rotate specific tiles
                if (shouldRotateTile90(row, col)) {
                    tile.transform.rotation = Quaternion.Euler(0, 0, 90); // Rotate by 90 degrees
                }
                if (shouldRotateTile270(row, col)) {
                    tile.transform.rotation = Quaternion.Euler(0, 0, 270); // Rotate by 90 degrees
                }
                if (shouldRotateTile180(row, col)) {
                    tile.transform.rotation = Quaternion.Euler(0, 0, 180); // Rotate by 90 degrees
                }
            }
        }
    }
}
bool shouldRotateTile180(int row, int col) {
    // Check if the tile at this row and column should be rotated
    // You can implement your custom logic here, such as checking specific rows and columns
    if ((row == 4 && col == 5) ||
(row == 3 && col == 11) ||
(row == 1 && col == 13) ||
(row == 2 && col == 13) ||
(row == 3 && col == 13) ||
(row == 4 && col == 11) ||
(row == 7 && col == 5) ||
(row == 8 && col == 8) ||
(row == 7 && col == 8) ||
(row == 10 && col == 5) ||
(row == 11 && col == 5) ||
(row == 12 && col == 5) ||
(row == 13 && col == 5) ||
(row == 13 && col == 8) ||
(row == 10 && col == 11) ||
(row == 3 && col == 5))
{
        return true; // Rotate the tile
    }
    return false; // Do not rotate the tile
}
bool shouldRotateTile270(int row, int col) {
    // Check if the tile at this row and column should be rotated
    // You can implement your custom logic here, such as checking specific rows and columns
    if ((row == 2 && col == 3) ||
(row == 2 && col == 5) ||
(row == 2 && col == 8) ||
(row == 2 && col == 9) ||
(row == 2 && col == 10) ||
(row == 2 && col == 11) ||
(row == 6 && col == 3) ||
(row == 6 && col == 4) ||
(row == 6 && col == 5) ||
(row == 6 && col == 8) ||
(row == 6 && col == 11) ||
(row == 6 && col == 12) ||
(row == 6 && col == 13) ||
(row == 7 && col == 13) ||
(row == 9 && col == 1) ||
(row == 9 && col == 2) ||
(row == 9 && col == 3) ||
(row == 9 && col == 4) ||
(row == 9 && col == 5) ||
(row == 12 && col == 11) ||
(row == 12 && col == 12) ||
(row == 10 && col == 10) ||
(row == 10 && col == 9) ||
(row == 9 && col == 11) ||
(row == 2 && col == 4)
)
{
        return true; // Rotate the tile
    }
    return false; // Do not rotate the tile
}
bool shouldRotateTile90(int row, int col) {
    // Check if the tile at this row and column should be rotated
    // You can implement your custom logic here, such as checking specific rows and columns
    if ((row == 0 && col == 1) ||
(row == 0 && col == 2) || 
(row == 0 && col == 3) || 
(row == 0 && col == 4) || 
(row == 0 && col == 5) || 
(row == 0 && col == 6) || 
(row == 0 && col == 7) ||
(row == 0 && col == 8) ||
(row == 0 && col == 9) ||
(row == 0 && col == 10) ||
(row == 0 && col == 11) ||
(row == 0 && col == 12) ||
(row == 4 && col == 3) ||
(row == 4 && col == 4) ||
(row == 4 && col == 7) ||
(row == 4 && col == 8) ||
(row == 4 && col == 9) ||
(row == 4 && col == 10) ||
(row == 4 && col == 13) ||
(row == 7 && col == 2) ||
(row == 7 && col == 3) ||
(row == 7 && col == 4) ||
(row == 9 && col == 8) ||
(row == 7 && col == 10) ||
(row == 7 && col == 11) ||
(row == 7 && col == 12) ||
(row == 9 && col == 0) ||
(row == 13 && col == 0) ||
(row == 13 && col == 1) ||
(row == 13 && col == 2) ||
(row == 13 && col == 3) ||
(row == 13 && col == 4) ||
(row == 13 && col == 7) ||
(row == 9 && col == 10) ||
(row == 9 && col == 9) ||
(row == 10 && col == 13) ||
(row == 4 && col == 2))
{
        return true; // Rotate the tile
    }
    return false; // Do not rotate the tile
}
}

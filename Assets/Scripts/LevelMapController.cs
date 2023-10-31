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

        // Iterate through the levelMap array and create game objects based on values
        for (int row = 0; row < numRows; row++)
        {
            for (int col = 0; col < numColumns; col++)
            {
                int tileValue = levelMap[row, col];

                // Ensure the tileValue corresponds to a valid tile prefab
                if (tileValue >= 0 && tileValue < tiles.Length)
                {
                    // Calculate the position for the tile based on row and column
                    Vector3 tilePosition = new Vector3(col * tileSize.x, -row * tileSize.y, 0f);

                    // Instantiate the appropriate tile prefab
                    GameObject tile = Instantiate(tiles[tileValue], tilePosition, Quaternion.identity);

                    // Optionally, you can parent the tile to a container for organization
                    // tile.transform.parent = transform;
                }
            }
        }
    }
}

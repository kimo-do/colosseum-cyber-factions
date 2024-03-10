using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class GridGenerator : MonoBehaviour
{
    public bool generate = false;
    public int width = 10;
    public int height = 20;
    public GameObject gridCellPrefab; // Assign a prefab with a SpriteRenderer component

    private GameObject[,] grid;

    void GenerateGrid()
    {
        grid = new GameObject[width, height];

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                GameObject newCell = Instantiate(gridCellPrefab, new Vector3(x, y, 0), Quaternion.identity, transform);

                // Assign a random sprite from the list to the grid cell
                SpriteRenderer sr = newCell.GetComponent<SpriteRenderer>();

                grid[x, y] = newCell;
            }
        }
    }

    private void Update()
    {
        if (generate)
        {
            generate = false;

            GenerateGrid();
        }
    }
}

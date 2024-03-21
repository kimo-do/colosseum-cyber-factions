#if UNITY_EDITOR
using UnityEngine;
using UnityEditor;
using UnityEditor.SceneManagement;
using UnityEngine.Rendering;

public class PrefabSpawnerEditor : EditorWindow
{
    public GameObject prefabToSpawn;
    public int width = 10;
    public int height = 20;

    [MenuItem("Window/Prefab Spawner")]
    public static void ShowWindow()
    {
        GetWindow(typeof(PrefabSpawnerEditor));
    }

    void OnGUI()
    {
        GUILayout.Label("Spawn Prefab Grid", EditorStyles.boldLabel);

        prefabToSpawn = (GameObject)EditorGUILayout.ObjectField("Prefab", prefabToSpawn, typeof(GameObject), false);
        width = EditorGUILayout.IntField("Width", width);
        height = EditorGUILayout.IntField("Height", height);

        if (GUILayout.Button("Spawn Prefab Grid"))
        {
            SpawnPrefabGrid();
        }
    }

    void SpawnPrefabGrid()
    {
        if (prefabToSpawn == null)
        {
            EditorUtility.DisplayDialog("Prefab Spawner", "Please assign a prefab.", "OK");
            return;
        }

        GameObject parentObject = new GameObject("PrefabGrid");
        Vector2 spriteSize = prefabToSpawn.GetComponent<SpriteRenderer>().bounds.size;

        float offsetX = width * spriteSize.x * 0.5f - spriteSize.x * 0.5f;
        float offsetY = height * spriteSize.y * 0.5f - spriteSize.y * 0.5f;
        Vector3 centeringOffset = new Vector3(offsetX, offsetY, 0);
        float zStep = 0.1f;

        for (int x = 0; x < width; x++)
        {
            for (int y = 0; y < height; y++)
            {
                float zPosition = zStep * (x * height + y);
                Vector3 spawnPosition = new Vector3(x * spriteSize.x, y * spriteSize.y, zPosition);
                GameObject prefabInstance = (GameObject)PrefabUtility.InstantiatePrefab(prefabToSpawn);
                prefabInstance.transform.position = spawnPosition;
                prefabInstance.transform.parent = parentObject.transform;

                prefabInstance.TryGetComponent(out CityBlock cityBlock);

                int sortingOrder = 1 * (x * height + y);

                // Set the sorting order of your mask
                prefabInstance.GetComponent<SortingGroup>().sortingOrder = sortingOrder;
                //cityBlock.mask.frontSortingOrder = sortingOrder;
                //cityBlock.backgroundSprite.sortingOrder = sortingOrder;
                //cityBlock.mask.isCustomRangeActive = true;


                // Set the sorting order of the objects that the mask should reveal
                foreach (var arw in cityBlock.arrowSprites)
                {
                    //arw.sortingOrder = sortingOrder;
                }

                cityBlock.gridPosition = new Vector2Int(x, y);
                EditorUtility.SetDirty(prefabInstance);
            }
        }

        // Center the parent object by adjusting its position
        parentObject.transform.position = new Vector3(-centeringOffset.x, -centeringOffset.y, 0);

        // Select the parent object for convenience
        Selection.activeGameObject = parentObject;

        EditorSceneManager.MarkSceneDirty(EditorSceneManager.GetActiveScene());
        AssetDatabase.SaveAssets();
    }
}
#endif
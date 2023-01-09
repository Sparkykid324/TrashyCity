using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour{
    public Vector2 gameGrid;
    public Vector3 cubeSize, worldPos;
    public GameObject tilingObject, selectedTile;
    public List<GameObject> gameObjectsInGrid = new List<GameObject>();


    void Start(){
        CreateMap();
    }

    void CreateMap(){
        for (int row = 1; row <= gameGrid.y; row++){
            for (int col = 1; col <= gameGrid.x; col++){

                GameObject thePrefab = tilingObject;
                GameObject theTile = Instantiate(thePrefab, transform);

                theTile.name = "Tile_" + col + "_" + row;
                theTile.transform.localPosition = new Vector3((col - 1) * cubeSize.x, 0f, (row - 1) * cubeSize.z);
                gameObjectsInGrid.Add(theTile);
            }

        }
        
        Debug.Log(gameObjectsInGrid.Count + " tiles in the map.");
    }

    void FixedUpdate() {
        foreach (GameObject cubes in gameObjectsInGrid){
            cubes.GetComponent<GameTile>().SetColour();
        }
    }
}
 
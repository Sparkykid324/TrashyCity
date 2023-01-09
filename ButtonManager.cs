using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour
{
    public GridManager gridManager;
    public GameTile currentTile;
    public GameObject building;

    // Start is called before the first frame update
    void Start(){
        gridManager = GameObject.Find("GridManager").GetComponent<GridManager>();
        
    }

    // Update is called once per frame
    void FixedUpdate(){
        currentTile = gridManager.selectedTile.GetComponent<GameTile>();

        }


    public void clickedButton(){

        if(gridManager.selectedTile != null){
            if(currentTile.currentState == GameTile.tileState.isSelected){
                Instantiate(building, gridManager.selectedTile.transform.position + (transform.up), Quaternion.identity);
                gridManager.selectedTile = null;
                currentTile.currentState = GameTile.tileState.hasBuilding;
                currentTile.SetColour();
            }
        }
    }
}

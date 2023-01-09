using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTile : MonoBehaviour
{

    public enum tileState {isSelected, canBuildOn, hasBuilding};
    public tileState currentState;
    private UIListener uiListener;

    public GridManager gridManager;
    // Start is called before the first frame update
    void Start(){
        gridManager = GameObject.Find("GridManager").GetComponent<GridManager>();
        currentState = tileState.canBuildOn;
        uiListener = GameObject.Find("Canvas").GetComponent<UIListener>();
    }

    void Update(){
        if (currentState == tileState.hasBuilding && gameObject.transform.childCount == 0){
            currentState = tileState.canBuildOn;
        }
    }


    void OnMouseDown() {
        if(!uiListener.uiOverride){
            if(currentState == tileState.hasBuilding){
                return;
            }

            if (currentState == tileState.isSelected ){
                currentState = tileState.canBuildOn;
            gridManager.selectedTile = null;
            }
            else{
                gridManager.selectedTile = this.gameObject;
            }
            SetColour();
        }
    }

    public void SetColour(){
        if (gridManager.selectedTile != null && gridManager.selectedTile.name == this.gameObject.name){
            currentState = tileState.isSelected;
        }
        else if(currentState != tileState.hasBuilding){
            currentState = tileState.canBuildOn;
        }


        switch(currentState){

            case tileState.canBuildOn:
                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.white);
                break;

            case tileState.hasBuilding:
                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.gray);
                break;

            case tileState.isSelected:
                gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
                break;
        }
    }
}

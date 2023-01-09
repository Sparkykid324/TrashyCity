using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommercialBuilding : MonoBehaviour
{
    public enum commState {isSelected, isNotSelected};
    public commState currentState;
    public GameObject buildingUI;

    void Start(){
        currentState = commState.isNotSelected;
        buildingUI = GameObject.Find("BuildingUI");
    }

    public void OnMouseDown(){
        if (currentState == commState.isNotSelected)
        {
            currentState = commState.isSelected;
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            buildingUI.GetComponent<Canvas>().enabled = true;

        }
    }
}

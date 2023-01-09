using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ResidentialBuilding : MonoBehaviour
{
    public enum resState {isSelected, isNotSelected};
    public resState currentState;
    public GameObject buildingUI;

    void Start(){
        currentState = resState.isNotSelected;
        buildingUI = GameObject.Find("BuildingUI");
    }

    public void OnMouseDown(){
        if (currentState == resState.isNotSelected)
        {
            currentState = resState.isSelected;
            gameObject.GetComponent<Renderer>().material.SetColor("_Color", Color.green);
            buildingUI.GetComponent<Canvas>().enabled = true;

        }
    }
}

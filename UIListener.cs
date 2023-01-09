using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class UIListener : MonoBehaviour
{
    public bool uiOverride {get; private set; }

    // Update is called once per frame
    void Update()
    {
        uiOverride = EventSystem.current.IsPointerOverGameObject();
    }
}

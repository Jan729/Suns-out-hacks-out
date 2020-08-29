using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectAndrew : MonoBehaviour
{
    public bool inRange;
    
    void OnMouseOver() {
        inRange = true;
    }

    void OnMouseExit() {
        inRange = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class hoverToNav : MonoBehaviour
{
    public bool inRange = false;
    public string levelName;
    public SpriteRenderer arrow;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver() {
        inRange = true;
        arrow.enabled = true;
    }

    void OnMouseExit() {
        inRange = false;
        arrow.enabled = false;
    }

    void OnMouseDown() {
        if(inRange) {
                SceneManager.LoadScene(levelName);
        }
    }
}

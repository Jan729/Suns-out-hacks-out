using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour
{
    public bool inRange = false;
    public string levelName;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inRange) {
            if(Input.GetMouseButtonDown(0)) {
                SceneManager.LoadScene(levelName);
            }
        }
    }

    void OnMouseOver() {
        inRange = true;
    }

    void OnMouseExit() {
        inRange = false;
    }
}

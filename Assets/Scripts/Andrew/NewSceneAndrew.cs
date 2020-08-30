using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class NewSceneAndrew : MonoBehaviour
{
    public bool inRange = false;
    public bool start = true;
    public SpriteRenderer arrow;
    public string levelName;
    public GameObject[] Interactables;

    // Start is called before the first frame update
    void Start()
    {
        arrow.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseOver() {
        inRange = true;
        for(int i = 0; i < Interactables.Length; i++) {
            if(!Interactables[i].GetComponent<DialogueManager>().start) {
                start = false;
            }
        }
        if(start) {
            arrow.enabled = true;
        }else {
            arrow.enabled = false;
        }
        
        start = true;
    }

    void OnMouseExit() {
        inRange = false;
        arrow.enabled = false;
    }

    void OnMouseDown() {
        for(int i = 0; i < Interactables.Length; i++) {
            if(!Interactables[i].GetComponent<DialogueManager>().start) {
                start = false;
            }
        }

        if(inRange && start) {
                SceneManager.LoadScene(levelName);
        }

        start = true;
    }
}

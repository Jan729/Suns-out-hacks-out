using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioSourceAndrew : MonoBehaviour
{
    public GameObject Dialogue;
    public AudioSource AudioFile;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        if(Dialogue.GetComponent<DialogueManager>().start == true) {
            AudioFile.Play();
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class EmilyDialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    private int index;
    public float typingSpeed = 0.02f;
    public GameObject continueButton;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Type());
        
    }

    IEnumerator Type() {
        foreach(char letter in sentences[index].ToCharArray()) {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }

    public void NextSentence(){
        
        continueButton.SetActive(false);
        if(index < sentences.Length - 1) {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        }else{
            textDisplay.text = "";
            continueButton.SetActive(false);
        }
    }





    // Update is called once per frame
    void Update()
    {
        if(textDisplay.text == sentences[index]) {
            continueButton.SetActive(true);
        }
    }
}

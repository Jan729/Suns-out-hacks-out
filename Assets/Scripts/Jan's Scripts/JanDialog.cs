using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class JanDialog : MonoBehaviour
{
    public TextMeshProUGUI textDisplay;
    public string[] sentences;
    public float typingSpeed = 0.02f;
    public GameObject continueButton;
    private int index;

    public void StartDialog()
    {
        StartCoroutine(Type());
    }

    public void Start()
    {
        continueButton.SetActive(false);
    }
    
    void Update()
    {
        if(textDisplay.text == sentences[index])
        {
            continueButton.SetActive(true);
        }
    } 

    IEnumerator Type()
    {
        foreach(char letter in sentences[index].ToCharArray())
        {
            textDisplay.text += letter;
            yield return new WaitForSeconds(typingSpeed);
        }
    }
    
    public void NextSentence()
    {
        continueButton.SetActive(false);

        if (index < sentences.Length - 1)
        {
            index++;
            textDisplay.text = "";
            StartCoroutine(Type());
        } else
        {
            continueButton.SetActive(false);
            textDisplay.text = "";
        }
    } 

}

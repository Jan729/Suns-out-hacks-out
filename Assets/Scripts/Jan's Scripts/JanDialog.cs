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
    public GameObject textBox;
    public GameObject emilyIcon;
    public GameObject clue;
    private int index = 0;

    public void StartDialog()
    {
        Debug.Log("starting dialog...");
        StartCoroutine(Type());
        textBox.SetActive(true);
        emilyIcon.SetActive(true);
        clue.SetActive(false);
    }

    public void Start()
    {
        continueButton.SetActive(false);
        textBox.SetActive(false);
        emilyIcon.SetActive(false);
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
            textBox.SetActive(false);
            emilyIcon.SetActive(false);
            textDisplay.text = "";
        }
    } 

}

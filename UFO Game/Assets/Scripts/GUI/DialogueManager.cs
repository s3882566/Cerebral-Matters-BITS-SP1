using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;

public class DialogueManager : MonoBehaviour
{
    public Text dialogueText;
    public Animator animator;
    private Queue<string> sentences;
    public AudioMixer audioMixer;

    void Start()
    {
        sentences = new Queue<string>();
    }

    public void StartDialogue(Dialogue dialogue)
    {

        animator.SetBool("IsOpen", true);
        sentences.Clear();

        // loop through sentences in dialogue and add them to queue
        foreach (string sentence in dialogue.sentences)
        {
            sentences.Enqueue(sentence);
        }

        DisplayNextSentence();
    }

    public void DisplayNextSentence()
    {


        Time.timeScale = 1f;
        if (sentences.Count == 0)
        {
            EndDialogue();
            return;
        }

        string sentence = sentences.Dequeue();
        StopAllCoroutines();
        StartCoroutine(TypeSentence(sentence));
    }

    IEnumerator TypeSentence(string sentence)
    {
        // Delay typewriter effect the dialogue has time to animate onto the screen first
        yield return new WaitForSeconds(0.25f);

        // Pause game after dialogue box has etered screen
        Time.timeScale = 0f;

        // Typewriter Effect
        dialogueText.text = "";
        foreach (char letter in sentence.ToCharArray())
        {
            dialogueText.text += letter;
            yield return null;
        }
    }

    void EndDialogue()
    {
        animator.SetBool("IsOpen", false);
    }


}

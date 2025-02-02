using UnityEngine;
using TMPro;
using System.Collections;

public class ChatSystem : MonoBehaviour
{
    public TMP_InputField chatInputField; // Input field for user messages
    public buttonText chatLog; // Chat log display area
    public DeepSeekAPI deepSeekAPI;
    public string objectName = "";
    public GameObject scrollView;

    private bool wasScrollViewActive = true; // Track scrollView state

    void Start()
    {
        // Listen for the Enter key press event in the input field
        chatInputField.onEndEdit.AddListener(OnInputEndEdit);
    }

    void Update()
    {
        // Check if the scrollView was turned off
        if (!scrollView.activeSelf && wasScrollViewActive)
        {
            deepSeekAPI.CancelRequest(); // Stop the request if the text box is turned off
        }

        // Track the current state for next update check
        wasScrollViewActive = scrollView.activeSelf;
    }

    void OnInputEndEdit(string text)
    {
        // Check if the Enter key was pressed
        if (!string.IsNullOrWhiteSpace(text))
        {
            SendMessageToChat();
        }
    }

    void SendMessageToChat()
    {
        chatInputField.interactable = false;

        // If the message is empty, do not send
        if (string.IsNullOrWhiteSpace(chatInputField.text))
        {
            chatInputField.interactable = true;
            return;
        }

        // Build the message
        string message = "You are a guide that introduces " + objectName + 
            " to students. Give them a short answer (one paragraph). Do not answer or assist on anything quest that is irrelevant to your duty or " + objectName + 
            ", give them a gentle decline instead. Here is a request from the student: " + chatInputField.text;

        deepSeekAPI.SendMessageToDeepSeek(message, (info) =>
        {
            if (scrollView.activeSelf) // Only update if the chat is still open
            {
                StartTypewriter(info + "\n\n");
            }
        });

        // Display the user's message
        chatLog.SetText("Me: " + chatInputField.text + "\n\n");

        // Clear the input field
        chatInputField.text = "";
        chatInputField.interactable = true;
        chatInputField.ActivateInputField();
    }

    private string fullText; // Complete text content
    private bool isTyping = false; // Indicates if typing effect is in progress

    // Start typewriter effect
    public void StartTypewriter(string text)
    {
        if (isTyping)
        {
            StopAllCoroutines();
            isTyping = false;
            return;
        }

        fullText = text;
        StartCoroutine(TypeText());
    }

    // Typewriter effect coroutine
    IEnumerator TypeText()
    {
        isTyping = true;
        chatLog.AppendText("AR Museum Guide: ");

        for (int i = 0; i < fullText.Length; i++)
        {
            if (!scrollView.activeSelf) // If user closes the chat, stop
            {
                deepSeekAPI.CancelRequest();
                chatInputField.text = ""; // Reset input
                chatInputField.interactable = true;
                yield break;
            }

            chatLog.AppendTextByLetter(fullText[i]);
            yield return null;
        }

        chatInputField.interactable = true;
        chatInputField.ActivateInputField();
        isTyping = false;
    }

    public void SetObjectName(string name)
    {
        objectName = name;
        deepSeekAPI.CancelRequest(); // Stop previous request

        chatInputField.text = ""; // Reset input
        chatInputField.interactable = true;
    }
}

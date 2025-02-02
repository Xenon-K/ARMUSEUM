using UnityEngine;
using UnityEngine.Networking;
using System.Collections;
using Newtonsoft.Json;
using UnityEngine.UI;
using UnityEngine.Events;

public class DeepSeekAPI : MonoBehaviour
{
    private string apiKey = "";//replace api
    private string apiUrl = "https://api.deepseek.com/v1/chat/completions";
    private Coroutine currentRequestCoroutine;
    private UnityWebRequest currentRequest;


    public  void SendMessageToDeepSeek(string message,UnityAction<string> callback)
    {
        if (currentRequestCoroutine != null)
        {
            StopCoroutine(currentRequestCoroutine);
            currentRequestCoroutine = null;
        }

        currentRequestCoroutine = StartCoroutine(PostRequest(message, callback));
    }

     IEnumerator PostRequest(string message, UnityAction<string> callback)
    {
        // create request
        var requestBody = new
        {
            model = "deepseek-chat",
            messages = new[]
            {
                new { role = "user", content = message }
            }
        };

        // use Newtonsoft.Json
        string jsonBody = JsonConvert.SerializeObject(requestBody);

        // create UnityWebRequest
        currentRequest = new UnityWebRequest(apiUrl, "POST");
        byte[] bodyRaw = System.Text.Encoding.UTF8.GetBytes(jsonBody);
        currentRequest.uploadHandler = new UploadHandlerRaw(bodyRaw);
        currentRequest.downloadHandler = new DownloadHandlerBuffer();
        currentRequest.SetRequestHeader("Content-Type", "application/json");
        currentRequest.SetRequestHeader("Authorization", "Bearer " + apiKey);

        // send the request
        yield return currentRequest.SendWebRequest();

        if (currentRequest.result == UnityWebRequest.Result.ConnectionError || currentRequest.result == UnityWebRequest.Result.ProtocolError)
        {
            Debug.LogError("Error: " + currentRequest.error);
            Debug.LogError("Response: " + currentRequest.downloadHandler.text); // print error message
        }
        else
        {
            // Handle the request
            string responseJson = currentRequest.downloadHandler.text;
            Debug.Log("Response: " + responseJson);


            // Parsing the request
            var response = JsonConvert.DeserializeObject<DeepSeekResponse>(responseJson);
            if (response != null && response.choices.Length > 0)
            {
                string reply = response.choices[0].message.content;
                Debug.Log("DeepSeek says: " + reply);
                callback(reply);
            }
            else
            {
                Debug.LogError("Failed to parse response.");
            }
        }
    }

    public void CancelRequest()
    {
        if (currentRequestCoroutine != null)
        {
            StopCoroutine(currentRequestCoroutine);
            currentRequestCoroutine = null;
        }

        if (currentRequest != null)
        {
            currentRequest.Abort();
            currentRequest = null;
        }
    }

    // Define the response data structure
    [System.Serializable]
    private class DeepSeekResponse
    {
        public Choice[] choices;
    }

    [System.Serializable]
    private class Choice
    {
        public Message message;
    }

    [System.Serializable]
    private class Message
    {
        public string role;
        public string content;
    }
}

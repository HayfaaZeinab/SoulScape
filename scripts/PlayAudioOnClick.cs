using UnityEngine;
using UnityEngine.UI;

public class PlayAudioOnClick : MonoBehaviour
{
    public Button startButton;  // Reference to the button
    public AudioSource audioSource; // Reference to the AudioSource

    void Start()
    {
        // Ensure both references are set
        if (startButton != null && audioSource != null)
        {
            startButton.onClick.AddListener(PlayAudio);
        }
    }

    void PlayAudio()
    {
        if (!audioSource.isPlaying) // Prevent multiple playbacks
        {
            audioSource.Play();
        }

        // Hide the button after clicking
        startButton.gameObject.SetActive(false);
    }
}


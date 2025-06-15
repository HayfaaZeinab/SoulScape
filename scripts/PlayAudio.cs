using UnityEngine;
using UnityEngine.UI;

public class PlayAudio : MonoBehaviour
{
    public AudioSource audioSource; // Reference to the AudioSource

    void Start()
    {
        if (audioSource == null)
        {
            audioSource = GetComponent<AudioSource>(); // Get AudioSource if not assigned
        }
    }

    public void PlaySound()
    {
        if (audioSource != null && audioSource.clip != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource or AudioClip missing!");
        }
    }
}

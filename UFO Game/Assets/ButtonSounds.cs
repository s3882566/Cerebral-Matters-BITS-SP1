using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// Script to add sounds on hover and click of UI buttons
// Drop script onto any button, add sound files to sound fields
public class ButtonSounds : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler, IPointerDownHandler
{
    [SerializeField] AudioClip clickSound;
    [SerializeField] AudioClip hoverSound;
    [SerializeField] [Range(0.0f, 1.0f)] float volume = 1;
    AudioSource audioSource;

    void Awake()
    {
        audioSource = gameObject.AddComponent<AudioSource>();
        audioSource.playOnAwake = false;
        audioSource.volume = volume;
    }

    // Detect if button is pressed and play click sound
    public void OnPointerDown(PointerEventData eventData)
    {
        // Stop hover sound
        audioSource.Stop();
        if (clickSound != null)
            audioSource.PlayOneShot(clickSound);
    }

    // Detect if the Cursor starts to pass over the GameObject and start looping hover sound
    public void OnPointerEnter(PointerEventData pointerEventData)
    {
        audioSource.loop = true;
        if (hoverSound != null)
            audioSource.clip = hoverSound;
        audioSource.Play();
    }

    // Detect when Cursor leaves the GameObject and stop hover sound
    public void OnPointerExit(PointerEventData pointerEventData)
    {
        audioSource.Stop();
    }


}

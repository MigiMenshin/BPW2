using UnityEngine;

public class FlashlightController : MonoBehaviour
{
    public GameObject flashlight;  // Reference to the flashlight game object
    public AudioSource clickSound;  // Reference to the AudioSource component

    private bool isFlashlightOn = false;

    void Start()
    {
        // Initialize the flashlight to be off
        flashlight.SetActive(false);
    }

    void Update()
    {
        // Check for the joystick button 2 press
        if (Input.GetKeyDown(KeyCode.JoystickButton2))
        {
            ToggleFlashlight();
        }
    }

    void ToggleFlashlight()
    {
        // Toggle the state
        isFlashlightOn = !isFlashlightOn;

        // Enable/disable the flashlight game object
        flashlight.SetActive(isFlashlightOn);

        // Play the click sound
        clickSound.Play();
    }
}

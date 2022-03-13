using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouse : MonoBehaviour
{
    public float mouseSensitivity = 100f; // Maus Geschwindigkeit. 

    public Transform playerBody; // Zugriff auf das Player-Objekt. 

    float xRot = 0f; // Rotation auf X-Achse initialisieren.
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked; // Mauszeiger Ausblenden und  in der Mitte des Bildschirms Sperren.
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * Time.deltaTime * mouseSensitivity ;// Maus-Koordinaten auf X-Achse.
        float mouseY = Input.GetAxis("Mouse Y") * Time.deltaTime * mouseSensitivity ;// Maus-Koordinaten auf Y-Achse.

        xRot -= mouseY;
        xRot = Mathf.Clamp(xRot, -90f, 90f);
        transform.localRotation = Quaternion.Euler(xRot, 0f, 0f);// die Umdrehung der Kamera hoch un runter.
        playerBody.Rotate(Vector3.up * mouseX);// Die Umdrehung des Players. 
    }
}

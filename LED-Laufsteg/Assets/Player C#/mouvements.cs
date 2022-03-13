using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mouvements : MonoBehaviour
{
    public CharacterController controller; //player 
    public float geschwindigkeit = 12f;// Geschwindigkeit 

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        float Right = Input.GetAxis("Horizontal");//Eingaben der koordinaten
        float Forward = Input.GetAxis("Vertical");//Eingaben der koordinaten

        Vector3 bewegen = transform.right * Right + transform.forward * Forward;// Bewegung in die Richtung, in die der Spieler zeigt
        controller.Move(bewegen * geschwindigkeit * Time.deltaTime);// Bewegung des Spielers

    }
}

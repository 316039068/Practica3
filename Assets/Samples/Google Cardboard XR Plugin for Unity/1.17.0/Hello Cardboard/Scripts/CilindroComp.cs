using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CilindroComp : MonoBehaviour
{
    // Referencia al objeto que deseas aparecer y desaparecer
    public GameObject objectToToggle;

    void Update()
    {
        // Verifica si se toca la pantalla en la parte derecha
        if (Input.touchCount > 0 && Input.GetTouch(0).position.x > Screen.width / 2)
        {
            // Cambia el estado de visibilidad del objeto
            objectToToggle.SetActive(!objectToToggle.activeSelf);
        }
    }
}




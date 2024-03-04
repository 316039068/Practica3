using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PruebaEscena : MonoBehaviour
{
    // Nombre de la escena a la que deseas cambiar
    public string Escena3;

    // Tiempo de espera antes de cambiar de escena (en segundos)
    public float delay = 2f;

    void Start()
    {
        // Comienza la corrutina para cambiar de escena después de un tiempo de espera
        StartCoroutine(SwitchSceneAfterDelay());
    }

    IEnumerator SwitchSceneAfterDelay()
    {
        // Espera el tiempo especificado antes de cambiar de escena
        yield return new WaitForSeconds(delay);

        // Cambiar a la escena especificada
        SceneManager.LoadScene(Escena3);
    }
}

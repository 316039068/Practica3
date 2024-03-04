using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioEscena : MonoBehaviour
{
    public float tiempoPorEscena = 10.0f; // Tiempo en segundos antes de cambiar de escena
    public string[] nombresEscenas; // Lista de nombres de las escenas en el orden en que quieres que se activen

    private int indiceEscenaActual = 0;
    private float tiempoTranscurrido = 0.0f;

    void Start()
    {
        // Inicializa el índice de la escena actual al comienzo
        indiceEscenaActual = 0;
    }

    void Update()
    {
        // Incrementa el tiempo transcurrido
        tiempoTranscurrido += Time.deltaTime;

        // Si el tiempo transcurrido es mayor o igual al tiempo por escena, cambia a la siguiente escena
        if (tiempoTranscurrido >= tiempoPorEscena)
        {
            CambiarEscena();
            Debug.Log("Tiempo transcurrido: " + tiempoTranscurrido);
            Debug.Log("Regreso: ");
        }
    }

    void CambiarEscena()
    {
        // Carga la siguiente escena
        SceneManager.LoadScene(nombresEscenas[indiceEscenaActual]);
        Debug.Log("Cambiando a la escena: " + nombresEscenas[indiceEscenaActual]);

        // Incrementa el índice de la escena actual
        indiceEscenaActual++;

        // Si llega al final de la lista de escenas, vuelve al principio del loop
        if (indiceEscenaActual >= nombresEscenas.Length)
        {
            indiceEscenaActual = 0;
            Debug.Log("Volviendo al principio de la lista de escenas.");
        }

        // Reinicia el tiempo transcurrido
        tiempoTranscurrido = 0.0f;
    }
}

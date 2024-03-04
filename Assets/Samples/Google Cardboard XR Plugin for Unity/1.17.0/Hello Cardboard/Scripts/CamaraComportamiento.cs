using UnityEngine;

public class CamaraComportamiento : MonoBehaviour
{
    // Sensibilidad de la rotaci�n de la c�mara
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // Obtener datos del giroscopio
        Vector3 gyroInput = Input.gyro.rotationRateUnbiased;

        // Aplicar rotaci�n a la c�mara
        transform.Rotate(-gyroInput.x * rotationSpeed, -gyroInput.y * rotationSpeed, gyroInput.z * rotationSpeed);
    }
}

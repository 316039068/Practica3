using UnityEngine;

public class CamaraComportamiento : MonoBehaviour
{
    // Sensibilidad de la rotación de la cámara
    public float rotationSpeed = 100.0f;

    void Update()
    {
        // Obtener datos del giroscopio
        Vector3 gyroInput = Input.gyro.rotationRateUnbiased;

        // Aplicar rotación a la cámara
        transform.Rotate(-gyroInput.x * rotationSpeed, -gyroInput.y * rotationSpeed, gyroInput.z * rotationSpeed);
    }
}

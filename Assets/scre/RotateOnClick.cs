using UnityEngine;

public class RotateOnClick : MonoBehaviour
{
    private bool isRotating = false;

    void Update()
    {
        if (isRotating)
        {
            transform.Rotate(Vector3.up * 100 * Time.deltaTime);
        }
    }

    private void OnMouseDown()
    {
        isRotating = !isRotating; // Переключаем вращение
    }
}

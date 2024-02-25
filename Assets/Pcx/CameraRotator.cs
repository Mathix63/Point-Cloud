using UnityEngine;

public class CameraRotator : MonoBehaviour {

    public float speedX;
    public float speedY;
    public float speedZ;

    private float rotationX = 0f;
    private float rotationY = 0f;
    private float rotationZ = 0f;

    void Update()
    {
        // Calculer la nouvelle rotation
        rotationX += Time.deltaTime * speedX;
        rotationY += Time.deltaTime * speedY;
        rotationZ += Time.deltaTime * speedZ;

        // Appliquer la rotation
        transform.eulerAngles = new Vector3(rotationX, rotationY, rotationZ);
    }
}
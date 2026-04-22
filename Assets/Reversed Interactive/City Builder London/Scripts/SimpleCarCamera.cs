using UnityEngine;

public class SimpleCarCamera : MonoBehaviour
{
    public float moveSpeed = 10f;
    public float rotationSpeed = 100f;

    void Update()
    {
        // Forward / backward movement
        float moveInput = 0f;
        if (Input.GetKey(KeyCode.UpArrow))
            moveInput = 1f;
        else if (Input.GetKey(KeyCode.DownArrow))
            moveInput = -1f;

        transform.Translate(Vector3.forward * moveInput * moveSpeed * Time.deltaTime);

        // Left / right rotation (steering)
        float turnInput = 0f;
        if (Input.GetKey(KeyCode.LeftArrow))
            turnInput = -1f;
        else if (Input.GetKey(KeyCode.RightArrow))
            turnInput = 1f;

        transform.Rotate(Vector3.up * turnInput * rotationSpeed * Time.deltaTime);
    }
}
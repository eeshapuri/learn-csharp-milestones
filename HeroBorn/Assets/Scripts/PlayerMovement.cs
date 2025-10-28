using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float turnSpeed = 90f;

    void Update()
    {
        // keyboard input (WSAD/Arrows)
        float move = Input.GetAxis("Vertical");
        float turn = Input.GetAxis("Horizontal");

        // to move forward&backward
        transform.Translate(Vector3.forward * move * moveSpeed * Time.deltaTime);

        // rotate
        transform.Rotate(Vector3.up, turn * turnSpeed * Time.deltaTime);
    }
}

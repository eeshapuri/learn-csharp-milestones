using UnityEngine;

public class CollisionDetector : MonoBehaviour
{
    void OnCollisionEnter(Collision collision)
    {
        Debug.Log($"{gameObject.name} hit {collision.gameObject.name}");
    }
    void OnCollisionExit(Collision collision)
    {
        Debug.Log($"{gameObject.name} swerved {collision.gameObject.name}");
    }
    void OnTriggerEnter(Collider other)
    {
        Debug.Log($"{gameObject.name} entered fun zone: {other.gameObject.name}");
    }
    void OnTriggerExit(Collider other)
    {
        Debug.Log($"{gameObject.name} exited fun zone: {other.gameObject.name}");
    }
}
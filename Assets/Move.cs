using UnityEngine;


    public class Mover : MonoBehaviour
{
    public float speed = 5.0f;
    private float xBoundary = 10f;
    private float zBoundary = 10f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontal, 0.0f, vertical) * speed * Time.deltaTime;

        Vector3 newPosition = transform.position + movement;
        newPosition.x = Mathf.Clamp(newPosition.x, -xBoundary, xBoundary);
        newPosition.z = Mathf.Clamp(newPosition.z, -zBoundary, zBoundary);

        transform.position = newPosition;
    }
}
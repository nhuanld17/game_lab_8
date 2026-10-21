using UnityEngine;

public class AirplaneMovement : MonoBehaviour
{
    public float speed = 3f;

    private void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.World);
    }
}
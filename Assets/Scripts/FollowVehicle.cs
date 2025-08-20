using UnityEngine;

public class FollowVehicle : MonoBehaviour
{
    public GameObject vehicle; // The vehicle to follow
    private Vector3 offset;

    void Start()
    {
        offset = transform.position - vehicle.transform.position;
    }

    void LateUpdate()
    {
        transform.position = vehicle.transform.position + offset;
    }
}

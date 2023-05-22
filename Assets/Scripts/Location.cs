
using UnityEngine;

public class Location
{
    public Vector3 position;
    public Quaternion rotation;

    public Location(Vector3 vector, Quaternion _rotation)
    {
        position = vector;
        rotation = _rotation;
    }
}

using UnityEngine;
using UnityEngine.Serialization;

public class CameraScript : MonoBehaviour
{
    public Transform Target;

    public float SmoothSpeed = 0.125f;
    [FormerlySerializedAs("offset")] public Vector3 Offset;

    void LateUpdate()
    {
        transform.position = Target.position + Offset;
    }


}

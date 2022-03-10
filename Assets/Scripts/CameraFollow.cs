using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform Player;
    public Transform BoxDistance2;
    public float DistanceFromPlayer = 5;
    public float StaticCameraY = 3;
    public float DistanceToStopCamera;
    public GameObject MainCamera;

    void Update()
    {

        if (Vector3.Distance(Player.position, BoxDistance2.position) > DistanceToStopCamera)
        {
            MainCamera.GetComponent<CameraFollow>().enabled = true;
        }
        else
        {
            MainCamera.GetComponent<CameraFollow>().enabled = false;
        }
        Vector3 tempPos = transform.position;

        tempPos.z = Player.position.z - DistanceFromPlayer;
        tempPos.x = Player.position.x + 6;

        transform.position = tempPos;
    }

    void LateUpdate()
    {
        Vector3 tempPos = Camera.main.transform.position;

        tempPos.y = StaticCameraY;

        Camera.main.transform.position = tempPos;
    }
}

using UnityEngine;

public class SpiderMove : MonoBehaviour
{
    public float LeftPoint = 10.9F; 
    public float RightPoint = 28.17F; 

    public int Direction = 1;

    public GameObject Spider;

    void Update()
    {

        if (Direction == 1)
        {
            transform.Translate(Vector3.right * 2 * Time.deltaTime, Space.World);
            Direction = 1;
        }

        if (this.transform.position.x > RightPoint)
        {
            Direction = 2;
            Spider.transform.Rotate(0, -180, 0);
        }

        if (Direction == 2)
        {
            transform.Translate(Vector3.right * -2 * Time.deltaTime, Space.World);
            Direction = 2;
        }

        if (this.transform.position.x < LeftPoint)
        {
            Direction = 1;
            Spider.transform.Rotate(0, 180, 0);
        }
    }
}
using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class MushromMoveIn : MonoBehaviour
{

    public GameObject ActualMushroom;
    public GameObject ThisMushroom;
    [FormerlySerializedAs("flag")] public int Flag = 0;

    public void Start()
    {
        ThisMushroom.SetActive(false);
    }
    public void Update()
    {
        ThisMushroom.transform.parent = null;
        ThisMushroom.transform.Translate(Vector3.up * 2 * Time.deltaTime, Space.World);
        StartCoroutine(CloseAnim());

    }
    IEnumerator CloseAnim()
    {
        yield return new WaitForSeconds(0.5F);
        ThisMushroom.SetActive(false);
        ActualMushroom.SetActive(true);
    }
}

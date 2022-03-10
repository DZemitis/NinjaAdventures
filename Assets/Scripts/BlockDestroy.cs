using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class BlockDestroy : MonoBehaviour
{
    [FormerlySerializedAs("XPos")] public float XPos;
    [FormerlySerializedAs("YPos")] public float YPos;
    [FormerlySerializedAs("ZPos")] public float ZPos;
    float waiting = 0.02F;

    IEnumerator OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.transform.position = new Vector3(XPos, YPos + 0.1F, ZPos);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(XPos, YPos + 0.2F, ZPos);
            yield return new WaitForSeconds(waiting);
            transform.GetComponent<Collider>().isTrigger = false;
            this.transform.position = new Vector3(XPos, YPos + 0.3F, ZPos + 0.5F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(XPos, YPos + 0.4F, ZPos + 1.0F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(XPos, YPos - 0.1F, ZPos + 1.5F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(XPos, YPos - 0.6F, ZPos + 2.0F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(XPos, YPos - 1.6F, ZPos + 2.0F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(XPos, YPos - 2.6F, ZPos + 2.0F);
            yield return new WaitForSeconds(waiting);
            this.transform.position = new Vector3(XPos, YPos - 4.0F, ZPos + 2.0F);
            yield return new WaitForSeconds(0.25F);
            transform.GetComponent<Collider>().isTrigger = true;
            Destroy(gameObject);
        }
    }

    // Use this for initialization
    void Start()
    {
        XPos = transform.position.x;
        YPos = transform.position.y;
        ZPos = transform.position.z;
    }
}
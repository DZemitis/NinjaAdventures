using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;

public class BlockNonDestroy : MonoBehaviour
{
    [FormerlySerializedAs("xPos")] public float XPos;
    [FormerlySerializedAs("yPos")] public float YPos;
    [FormerlySerializedAs("zPos")] public float ZPos;
    public AudioSource bump;

    IEnumerator OnTriggerEnter(Collider col)
    {
        transform.GetComponent<Collider>().isTrigger = false;
        if (col.gameObject.tag == "Player")
        {
            bump.Play();
            this.transform.position = new Vector3(XPos, YPos + 0.2F, ZPos);
            yield return new WaitForSeconds(0.08F);
            this.transform.position = new Vector3(XPos, YPos, ZPos);
            yield return new WaitForSeconds(0.25F);
            transform.GetComponent<Collider>().isTrigger = true;
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

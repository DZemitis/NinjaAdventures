using System.Collections;
using UnityEngine;

public class Qblock001 : MonoBehaviour
{
    public GameObject QBlock;
    public GameObject DeadBlock;
    public GameObject Mushroom;
    public GameObject Trigger;

    IEnumerator OnTriggerEnter(Collider col)
    {
        QBlock.SetActive(false);
        DeadBlock.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        Mushroom.SetActive(true);
        Trigger.GetComponent<Collider>().enabled = false;
        //changed the QuestionBlock001Collision to be size 1, .7, 1 instead of smaller so that player doesn't get stuck in block
    }
}
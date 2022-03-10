using System.Collections;
using UnityEngine;
using static UnityEngine.Application;

public class Level01_load : MonoBehaviour
{
    [System.Obsolete]
    void Start()
    {
        StartCoroutine(Anim());
    }

    IEnumerator Anim()
    {
        yield return new WaitForSeconds(1f);
        LoadLevel(2);
    }
}

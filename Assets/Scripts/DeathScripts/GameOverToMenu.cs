using System.Collections;
using UnityEngine;
using static UnityEngine.Application;

public class GameOverToMenu : MonoBehaviour
{
    public void Start()
    {
        StartCoroutine(CloseAnim());
    }

    IEnumerator CloseAnim()
    {
        yield return new WaitForSeconds(3f);
        LoadLevel(0);
    }
}

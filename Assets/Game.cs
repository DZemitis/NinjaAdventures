using System.Collections;
using UnityEngine;

public class Game : MonoBehaviour
{
    [SerializeField] private Animator fade;


    public void Start()
    {
        StartCoroutine(Animation());
    }

    public void Update()
    {

    }

    IEnumerator Animation()
    {
        fade.enabled = true;
        yield return new WaitForSeconds(360f);
        fade.enabled = false;
    }
}

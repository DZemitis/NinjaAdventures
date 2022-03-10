using System.Collections;
using UnityEngine;

public class PIpeUp : MonoBehaviour
{

    [SerializeField] Animator PipeCollider;
    [SerializeField] Animator FadeScreen;

    public GameObject MainCam;
    public GameObject SecondCam;
    public GameObject MainPlayer;
    public GameObject PipeBlock;
    public AudioSource PipeSound;
    public GameObject PipeBox;
    public GameObject PipeBox2;
    public GameObject PipeBox3;


    IEnumerator OnTriggerEnter(Collider col)
    {
        PipeBox.GetComponent<Collider>().enabled = false;
        PipeBox2.GetComponent<Collider>().enabled = false;
        PipeSound.Play();
        FadeScreen.enabled = true;
        yield return new WaitForSeconds(1f);
        MainCam.SetActive(true);
        SecondCam.SetActive(false);
        PipeCollider.enabled = true;
        MainPlayer.transform.position = new Vector3(29.15f, 1, 0.5F);
        yield return new WaitForSeconds(0.7f);

        FadeScreen.enabled = false;
        yield return new WaitForSeconds(0.28f);
        PipeCollider.enabled = false;
        PipeBlock.GetComponent<Collider>().enabled = true;
        PipeBox.GetComponent<Collider>().enabled = true;
        PipeBox3.GetComponent<Collider>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        PipeBox2.GetComponent<Collider>().enabled = true;
    }
}

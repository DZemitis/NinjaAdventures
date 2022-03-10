using System.Collections;
using UnityEngine;

public class PipeAnim : MonoBehaviour
{

    [SerializeField] Animator PipeCollider;
    [SerializeField] Animator FadeScreen;

    public static int StoodOn;

    public GameObject MainCam;
    public GameObject SecondCam;
    public GameObject MainPlayer;
    public AudioSource PipeSound;
    public GameObject Pipe;
    public GameObject Pipe2;


    void OnTriggerEnter(Collider col)
    {
        StoodOn = 1;
    }

    void OnTriggerExit(Collider col)
    {
        StoodOn = 0;
    }

    // Use this for initialization
    void Start()
    {
        PipeCollider.enabled = false;
        FadeScreen.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.S))
        {
            if (StoodOn == 1)
            {
                transform.position = new Vector3(0, -1000, 0);
                StartCoroutine(WaitingForPipe());
                //pipeCollider.enabled = true;               
            }
        }
    }

    IEnumerator WaitingForPipe()
    {
        PipeSound.Play();
        FadeScreen.enabled = true;
        PipeCollider.enabled = true;
        yield return new WaitForSeconds(1);
        PipeCollider.enabled = false;
        SecondCam.SetActive(true);
        MainCam.SetActive(false);
        MainPlayer.transform.position = new Vector3(6, -27f, 0.5F);
        yield return new WaitForSeconds(0.5f);
        Pipe.GetComponent<Collider>().enabled = true;
        Pipe2.GetComponent<Collider>().enabled = true;
        yield return new WaitForSeconds(0.5f);
        FadeScreen.enabled = false;
    }
}
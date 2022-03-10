using System.Collections;
using UnityEngine;

public class ChestScript : MonoBehaviour
{

    [SerializeField] Animator ChestTop;
    [SerializeField] Animator PlayerDance;
    public Rigidbody Player;
    public GameObject SpotLight;
    public GameObject SpotLight2;
    public GameObject SpotLight3;
    public AudioSource ChestSound;
    public AudioSource GameSound;

    IEnumerator OnTriggerEnter(Collider col)
    {
        GameSound.Stop();
        ChestSound.Play();
        Player.constraints = RigidbodyConstraints.FreezePosition;
        PlayerDance.SetTrigger("Dance");
        yield return new WaitForSeconds(0.30f);
        ChestTop.enabled = true;
        yield return new WaitForSeconds(0.1f);
        SpotLight.SetActive(true);
        yield return new WaitForSeconds(0.2f);
        SpotLight2.SetActive(true);
        SpotLight3.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        ChestTop.enabled = false;
        yield return new WaitForSeconds(5f);
        Application.LoadLevel(4);
    }
}
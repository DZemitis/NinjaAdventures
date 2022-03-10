using System.Collections;
using UnityEngine;

public class SpiderDeath : MonoBehaviour
{
    public GameObject MushroomMan;
    [SerializeField] public Animator SpiderD;
    public Rigidbody Player;
    public float CollisionForce;
    public AudioSource Die;

    IEnumerator OnTriggerEnter(Collider col)
    {
        Die.Play();
        SpiderD.SetTrigger("Die");
        this.GetComponent<BoxCollider>().enabled = false;
        Player.velocity = Vector3.up * CollisionForce;
        yield return new WaitForSeconds(1);
        MushroomMan.transform.position = new Vector3(0, -1000, 0);
    }
}
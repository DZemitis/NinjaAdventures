using UnityEngine;
using UnityEngine.Serialization;

public class CoinPickup : MonoBehaviour
{
    [FormerlySerializedAs("coinSound")] public AudioSource CoinSound;
    [FormerlySerializedAs("coinSound2")] public AudioSource CoinSound2;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            transform.position = new Vector3(0, -1000, 0);
            CoinSound.Play();
            CoinSound2.Play();
            GlobalCoins.CoinCount++;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
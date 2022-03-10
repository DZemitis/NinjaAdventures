using System.Collections;
using UnityEngine;
using UnityEngine.Serialization;
using static UnityEngine.Application;

public class Level01Death : MonoBehaviour
{
    [FormerlySerializedAs("death")] public AudioSource Death;
    public GameObject LevelMusic;
    public GameObject Player;

    IEnumerator OnTriggerEnter(Collider col)
    {
        LevelMusic.SetActive(false);
        Death.Play();
        Player.SetActive(false);
        yield return new WaitForSeconds(2f);
        GlobalLives.LiveCount = 3;
        GlobalCoins.CoinCount = 0;
        LoadLevel(1);
    }
}

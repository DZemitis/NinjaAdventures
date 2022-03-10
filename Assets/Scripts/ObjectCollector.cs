using UnityEngine;
using UnityEngine.Serialization;

public class ObjectCollector : MonoBehaviour
{
    [FormerlySerializedAs("levelUp")] public AudioSource LevelUp;
    [FormerlySerializedAs("levelUp2")] public AudioSource LevelUp2;

    void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            transform.position = new Vector3(0, -1000, 0);
            LevelUp.Play();
            LevelUp2.Play();
            if (GlobalLives.LiveCount >= 5)
            {
                GlobalCoins.CoinCount++;
            }
            else
            {
                GlobalLives.LiveCount++;
            }
        }
    }
}

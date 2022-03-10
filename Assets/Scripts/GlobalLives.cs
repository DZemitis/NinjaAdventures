using UnityEngine;
using UnityEngine.UI;

public class GlobalLives : MonoBehaviour
{

    public GameObject LivesDisplay;

    public static int LiveCount = 3;

    public int InternalLives;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        InternalLives = LiveCount;
        LivesDisplay.GetComponent<Text>().text = "Lives: " + LiveCount;
    }
}

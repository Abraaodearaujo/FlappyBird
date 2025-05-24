using UnityEngine;
using UnityEngine.UI;
public class Score : MonoBehaviour
{
    public Text scoreTxt;
    public static float scoreValue;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        scoreValue = 0;
        scoreTxt.text = scoreValue.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        scoreTxt.text = scoreValue.ToString();
    }
}

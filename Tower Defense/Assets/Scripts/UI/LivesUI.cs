using UnityEngine;
using UnityEngine.UI;

public class LivesUI : MonoBehaviour
{
    private Text livesText;

    private void Start()
    {
        livesText = GetComponent<Text>();
    }
    private void Update()
    {
        LiveClamping();
        livesText.text = PlayerStats.Lives + " LIVES";
    }
    private int LiveClamping()
    {
        if (PlayerStats.Lives < 0)
            return PlayerStats.Lives = 0;
        else
            return PlayerStats.Lives;
    }
}

using UnityEngine;
using UnityEngine.UI;
public class score_updater : MonoBehaviour
{

    public static int player_points;
    public TMPro.TMP_Text scoreText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player_points = 0;
        UpdateScoreDisplay();
    }
    public void AddPoints(int points)
    {
        player_points += points;
        UpdateScoreDisplay();
    }

    void UpdateScoreDisplay()
    {
        
        {
            scoreText.text = player_points.ToString();
        }
    }
    // Update is called once per frame
    void Update()
    {
        UpdateScoreDisplay();
    }
}

using UnityEngine; 
using TMPro; 
public class ScoreManager : MonoBehaviour 
{ 
    public TextMeshProUGUI scoreText; 
    private int score = 0; 
    void UpdateScoreText()     
    {         
        scoreText.text = "Score: " + score;     
    } 
    public void AddScoreOnClick()     
    {         
        score += 10;
        UpdateScoreText();
    } 
} 
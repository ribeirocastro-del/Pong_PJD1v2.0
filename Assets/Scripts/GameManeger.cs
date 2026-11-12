using TMPro;
using UnityEngine;

public class GameManeger : MonoBehaviour
{
    [SerializeField] private int playerScore;
    [SerializeField] private int aiScore;
    [SerializeField] private TextMeshProUGUI playerScoreText;
    [SerializeField] private TextMeshProUGUI aiScoreText;

    public void PlayerAddPoint()
    {
        playerScore++;
        playerScoreText.text = playerScore.ToString();

    }

    public void AIAddPoint()
    {
        aiScore++;
        aiScoreText.text = aiScore.ToString();
    }
    
    
    
    
}

using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public Square playerSquare;
    public Square computerSquare;
    private int _playerScore;
    private int _computerScore;
    public Ball ball;
    public Text playerScoreText;
    public Text computerScoreText;

    public void PlayerScore()
    {
        _playerScore++;
        this.playerScoreText.text = _playerScore.ToString();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerSquare.ResetPostion();
        this.computerSquare.ResetPostion();
    }

    public void ComputerScore()
    {
        _computerScore++;
        this.computerScoreText.text = _computerScore.ToString();
        this.ball.ResetPosition();
        this.ball.AddStartingForce();
        this.playerSquare.ResetPostion();
        this.computerSquare.ResetPostion();
    }

}

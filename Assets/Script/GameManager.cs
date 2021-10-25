using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance { get; private set; } = null;

    public enum GameState
    {
        PREPARATION,
        RUNNIG,
        END,
    }

    private GameState gameState { get; set; } = GameState.PREPARATION;

    private float gameTimer { get; set; } = 0;

    public float _preparationTime = 10;

    private float preparationTime { get { return _preparationTime; } }

    private void Awake()
    {
        instance = this;
    }

    private void Start()
    {
        gameTimer = preparationTime;
    }

    private void Update()
    {
        switch (gameState)
        {
            case GameState.PREPARATION:
                gameTimer -= Time.deltaTime;
                UiManager.instance.SetTimer(gameTimer);
                if(gameTimer < 0)
                {
                    gameTimer = preparationTime;
                    gameState = GameState.RUNNIG;
                }

                break;

            case GameState.RUNNIG:
                break;

            case GameState.END:
                break;
        }
    }
}

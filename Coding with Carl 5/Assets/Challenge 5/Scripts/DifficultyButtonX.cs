using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DifficultyButtonX : MonoBehaviour
{
    private Button button;
    private GameManagerX gameManagerX;
    public int difficulty;

    // Start is called before the first frame update
    void Start()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(SetDifficulty);
        gameManagerX = GameObject.Find("Game Manager").GetComponent<GameManagerX>();
    }
    
    void SetDifficulty()
    {
        Debug.Log(button.gameObject.name + "was clicked");
        gameManagerX.StartGame(difficulty);
    }
}

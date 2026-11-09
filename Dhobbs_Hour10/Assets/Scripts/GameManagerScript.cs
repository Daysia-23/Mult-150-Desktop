using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerScript : MonoBehaviour
{
    // Start is called before the first frame update
    
    
    void Start()
    {
        
    }
    
    
    
    // Update is called once per frame
    public GoalScript blue, green, red, orange, chaos;
    private bool isGameOver = true;
    void Update()
    {
        isGameOver = blue.isSolved && green.isSolved && red.isSolved && orange.isSolved && chaos.isSolved;
    }

    private void OnGUI()
    {
        if (isGameOver)
        {
            Rect rect = new Rect(Screen.width / 2 - 100, Screen.height / 2 - 50, 200, 75);
            GUI.Box (rect, "Game Over");
            Rect rect2 = new Rect(Screen.width / 2 - 30, Screen.height / 2 - 25, 60, 50);
            GUI.Box (rect2, "Good Job!");
        }
    }
    
}

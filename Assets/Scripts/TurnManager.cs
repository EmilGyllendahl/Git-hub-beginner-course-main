using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private static TurnManager instance;

    private int currentPlayerIndex; //  The variable for which of the players turn it is

    private void Awake()
    {
        if (instance == null) // If it is empty on awake and not assigned 
        {
            instance = null;
            currentPlayerIndex = 1; //  Then tWhen the turn starts Player 1 starts when the game starts/Awakes
        }
        
    }

    public bool IsItPlayerTurn(int index) // Checks the index for the current player
    {
        return index == currentPlayerIndex; // Returns the index for the current player
    }

    public static TurnManager GetInstance() // The TurnManager checks the instance
    {
        return instance;
    }

    public void ChangeTurn() 
    {
        if (currentPlayerIndex == 1) // When the turn changes and it is the index of player 1
        {
            currentPlayerIndex = 2; // Change to the player of index 2
        }

        else if (currentPlayerIndex == 2) // When the turn changes and it is the index of player 2
        {
            currentPlayerIndex = 1;  // Change to the player of index 1
        }
    }
}

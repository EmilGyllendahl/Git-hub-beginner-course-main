using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TurnManager : MonoBehaviour
{
    private static TurnManager instance;
    [SerializeField] private PlayerTurn playerOne; // Playerone
    [SerializeField] private PlayerTurn playerTwo;
    [SerializeField] private float timeBetweenTurns; // Time between turns taken.


    private int currentPlayerIndex; //  The variable for which of the players turn it is
    private bool waitingForNextTurn;
    private float turnDelay;


    private void Awake()
    {
        if (instance == null) // If it is empty on awake and not assigned 
        {
            instance = null;
            currentPlayerIndex = 1; //  Then tWhen the turn starts Player 1 starts when the game starts/Awakes
            playerOne.SetPlayerTurn(1);
            playerTwo.SetPlayerTurn(2);
        }
        
    }

    private void Update()
    {
        if (waitingForNextTurn)
        {
            turnDelay += Time.deltaTime;
            if (turnDelay >= timeBetweenTurns)
            {
                turnDelay = 0;
                waitingForNextTurn = false; // If the game is waiting for the next turn
                ChangeTurn();
            }
        }
    }

    public bool IsItPlayerTurn(int index) // Checks the index for the current player
    {
        if (waitingForNextTurn) //
        {
            return false; 
        }
    
        return index == currentPlayerIndex; // Returns the index for the current player
    }

    public static TurnManager GetInstance() // The TurnManager checks the instance
    {
        return instance;
    }

    public void TriggerChangeTurn()
    {
        waitingForNextTurn = true;
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

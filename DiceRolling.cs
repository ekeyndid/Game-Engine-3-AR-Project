using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRolling : Player
{
    public Player player1;
    public Player player2;
    bool Player1Turn;
    bool Player2Turn;
    void Start()
    {
        Player1Turn = true;
        Player2Turn = false;
    }

    void Update()
    {
        if (Player1Turn == true && Input.GetMouseButtonDown(0))
        {
            Player1Turn = false;
            int DiceResult = Random.Range(1, 6);
            player1.MoveSpaces(DiceResult);
            switch (player1.getSpace())
            {
                case 2:
                    player1.MoveSpaces(15);
                    break;
                case 9:
                    player1.MoveSpaces(15);
                    break;
                case 15:
                    player1.MoveSpaces(14);
                    break;
                case 41:
                    player1.MoveSpaces(-15);
                    break;
                case 48:
                    player1.MoveSpaces(-13);
                    break;
                default:
                    break;
            }
            if(player1.getSpace() < 49)
            {
                Player2Turn = true;
            }
            else
            {
                print("Player1 has won");
            }
        }
        if (Player2Turn == true && Input.GetMouseButtonDown(0))
        {
            Player2Turn = false;
            int DiceResult2 = Random.Range(1, 6);
            player2.MoveSpaces(DiceResult2);
            switch (player2.getSpace())
            {
                case 2:
                    player2.MoveSpaces(15);
                    break;
                case 9:
                    player2.MoveSpaces(25);
                    break;
                case 15:
                    player2.MoveSpaces(14);
                    break;
                case 41:
                    player2.MoveSpaces(-15);
                    break;
                case 48:
                    player2.MoveSpaces(-13);
                    break;
                default:
                    break;
            }
            if (player2.getSpace() < 49)
            {
                Player1Turn = true;
            }
            else
            {
                print("Player2 has won");
            }
        }
    }
}

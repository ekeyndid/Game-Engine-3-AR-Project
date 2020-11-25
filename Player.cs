using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int CurrentSpace;
    public GameObject playerCube;
        private void Start()
    {
        CurrentSpace = 1;
    }
    public void MoveSpaces(int ChangeInMovement)
    {
       CurrentSpace += ChangeInMovement;
    }
    public int getSpace()
    {
        return CurrentSpace;
    }
}

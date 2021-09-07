using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public const int WALL_FRONT = 1; 
    public const int WALL_RIGHT = 2; 
    public const int WALL_BACK = 3; 
    public const int WALL_LEFT = 4;

    public GameObject pane1Walls;

    private int wallNo;

    public GameObject buttonMessage;
    public GameObject buttonMessageText;


    void Start()
    {
        wallNo = WALL_FRONT;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PushButtonMemo()
    {
        DisplayMessage("エッフェル塔と書いてある");
    }

    public void PushButtonMessage()
    {
        buttonMessage.SetActive(false); //　メッセージを消す
    }

    public void PushButtonRight()
    {
        wallNo++;
        if(wallNo > WALL_LEFT)
        {
            wallNo = WALL_FRONT;
        }
        DisplayWall();
    }

    public void PushButtonLeft()
    {
        wallNo--;
        if (wallNo < WALL_FRONT)
        {
            wallNo = WALL_LEFT;
        }
        DisplayWall();
    }

    void DisplayMessage(string mes)
    {
        buttonMessage.SetActive(true);
        buttonMessageText.GetComponent<Text>().text = mes;
    }

    void DisplayWall()
    {
        switch (wallNo)
        {
            case WALL_FRONT:
                pane1Walls.transform.localPosition = new Vector3(0.0f, 0.0f, 0.0f);
                break;
            case WALL_RIGHT:
                pane1Walls.transform.localPosition = new Vector3(-1000.0f, 0.0f, 0.0f);
                break;
            case WALL_BACK:
                pane1Walls.transform.localPosition = new Vector3(-2000.0f, 0.0f, 0.0f);
                break;
            case WALL_LEFT:
                pane1Walls.transform.localPosition = new Vector3(-3000.0f, 0.0f, 0.0f);
                break;
        }
    }


    
}

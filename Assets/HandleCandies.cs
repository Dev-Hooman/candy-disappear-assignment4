using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HandleCandies : MonoBehaviour
{
    public  GameObject candy1;
    public  GameObject candy2;
    public  GameObject candy3;
    public  GameObject candy4;


    private void Update()
    {
        if ( Input.GetKeyDown(KeyCode.Delete))
        {
            Debug.Log("SET ACTIVE");
            candy1.SetActive(true);
            candy2.SetActive(true);
            candy3.SetActive(true);
            candy4.SetActive(true);

        }
    }
    private void ReactivateObjects()
    {


        //candy1.transform.position = GetBottomLeftCornerPosition();
        //candy2.transform.position = GetBottomRightCornerPosition();
        //candy3.transform.position = GetTopLeftCornerPosition();
        //candy4.transform.position = GetTopRightCornerPosition();

        //ClickToMove.ResetMovement();
    }


    private Vector3 GetBottomLeftCornerPosition()
    {
        Vector3 bottomLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, 0, -1));
        bottomLeft.z = 0f;
        return bottomLeft;
    }

    private Vector3 GetBottomRightCornerPosition()
    {
        Vector3 bottomRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, 0, -1));
        bottomRight.z = 0f;
        return bottomRight;
    }

    private Vector3 GetTopLeftCornerPosition()
    {
        Vector3 topLeft = Camera.main.ScreenToWorldPoint(new Vector3(0, Screen.height, -1));
        topLeft.z = 0f;
        return topLeft;
    }

    private Vector3 GetTopRightCornerPosition()
    {
        Vector3 topRight = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, -1));
        topRight.z = 0f;
        return topRight;
    }

}

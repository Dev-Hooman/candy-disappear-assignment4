using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClickToAppear : MonoBehaviour
{
    private GameObject[] targetObjects;
    [SerializeField] public Text InfoText;


    [SerializeField] private string[] gameObjectNames;

    public static bool isGameObjectVisible = false;

    private void Start()
    {
        targetObjects = new GameObject[gameObjectNames.Length];

        for (int i = 0; i < gameObjectNames.Length; i++)
        {
            targetObjects[i] = GameObject.Find(gameObjectNames[i]);
            targetObjects[i].SetActive(false);
        }
    }

    private void Update()
    { 
        if (Input.GetMouseButtonDown(0))
        {
            if (isGameObjectVisible == false)
            {
                InfoText.text = "";
            }

            Debug.Log("Working ?");
            for (int i = 0; i < targetObjects.Length; i++)
            {
                isGameObjectVisible = true;
                targetObjects[i].SetActive(true);
            }
        }
    }
}

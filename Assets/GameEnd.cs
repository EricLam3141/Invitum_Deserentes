using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    // Start is called before the first frame update
    public void Setup(int score)
    {
        gameObject.SetActive(true);
        
    }

    public void ExitButton()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}

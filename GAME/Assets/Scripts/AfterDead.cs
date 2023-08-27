using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AfterDead : MonoBehaviour
{
    public void PlayAggain()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

        FindObjectOfType<GameManager>().RemoveCoin();

    }

    public void Exit()
    {
        Debug.Log("Game close");
        Application.Quit();
    }
    
}

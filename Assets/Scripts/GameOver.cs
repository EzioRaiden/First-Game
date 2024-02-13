using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOver : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag=="Player")
        {
            SceneManager.LoadScene(1);
        }
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(0);
    }
    
}

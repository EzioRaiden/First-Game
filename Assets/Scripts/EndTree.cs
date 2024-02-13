using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndTree : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if(other.transform.tag=="Player")
        {
            SceneManager.LoadScene(2);
        }
    }
    public void RetryGame()
    {
        SceneManager.LoadScene(0);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class EnemyContact : MonoBehaviour
{
    void OnCollisionEnter(Collision Collection)
    {
        if(Collection.gameObject.name=="Player1")
        {
            //Destroy(Collection.gameObject);
            SceneManager.LoadScene(3);            
        }
    }
    public void ReplayGame()
    {
        SceneManager.LoadScene(0);
    }

}


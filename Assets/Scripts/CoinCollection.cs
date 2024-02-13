using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollection : MonoBehaviour
{
   private int coinNo = 0;
   public Text coinText;
 
   private void OnTriggerEnter(Collider other)
   {
    if(other.transform.tag=="Coin")
    {
        coinNo++;
        coinText.text ="Coin: " + coinNo.ToString();
        Debug.Log(coinNo);
        Destroy(other.gameObject);
    }
    
   }
}

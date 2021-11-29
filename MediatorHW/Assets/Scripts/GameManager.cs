using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static int CoinsRecieved = 0;
    // Start is called before the first frame update
    void Start()
    {
        CoinsRecieved = Coins.CoinCount;
    }

    // Update is called once per frame
    void Update()
    {
        Coins.CoinCount = CoinsRecieved;
        CoinsRecieved = Coins.CoinCount;
        Debug.Log(CoinsRecieved);
    }
}

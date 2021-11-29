using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coins : MonoBehaviour
{
    public static int CoinCount = 3;
    public static bool IsEmpty = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (CoinCount <= 0)
        {
            IsEmpty = true;
        }
        else if(CoinCount > 0)
        {
            IsEmpty = false;
        }
        Debug.Log("empty"+IsEmpty);
    }
}

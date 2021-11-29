using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shop : MonoBehaviour
{
    private bool _trigger;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (_trigger && Input.GetKeyDown(KeyCode.F))
        {
            FillCoins(Coins.IsEmpty);
        }
    }

    void FillCoins(bool IsEmpty)
    {
        if (IsEmpty)
        {
            GameManager.CoinsRecieved = 3;
            Debug.Log(GameManager.CoinsRecieved);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _trigger = true;
    }
    private void OnTriggerExit(Collider other)
    {
        _trigger = false;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slot : MonoBehaviour
{
    private bool _triggered = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (_triggered && Input.GetKeyDown(KeyCode.F)&&GameManager.CoinsRecieved>0)
        {
            GameManager.CoinsRecieved--;
        }
        else if (GameManager.CoinsRecieved<=0)
        {
            Debug.Log("You Dont Have Enough Coins To Play, Go Buy Some");
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        _triggered = true;
    }
    private void OnTriggerExit(Collider other)
    {
        _triggered = false;
    }
}

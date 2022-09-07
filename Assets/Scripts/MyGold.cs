using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Purchasing;
using Unity.VisualScripting;

public class MyGold : MonoBehaviour
{
    private double _totalMyComosixGold;
     public Text currentComosixGold;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BuyGold(UnityEngine.Purchasing.Product product)
    {
        CustomEvent.Trigger(gameObject, "BuyComosixGold", product.definition.payout.quantity);
        _totalMyComosixGold += product.definition.payout.quantity;
        currentComosixGold.text = "Comosix Gold: " + _totalMyComosixGold;
    }
}

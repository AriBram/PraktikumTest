using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class CoinCounter : MonoBehaviour
{
    int coins = 0;
    TMP_Text counter;

    void Start()
    {
        counter = GetComponent<TMP_Text>();
        SetCounter();
    }

    public void AddCoin()
    {
        coins++;
        SetCounter();
    }

    private void SetCounter()
    {
        counter.text = coins.ToString();
    }
}

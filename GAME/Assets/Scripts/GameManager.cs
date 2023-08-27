using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : MonoBehaviour
{
    [SerializeField] private TextMeshProUGUI _coinsText;
    private int _coinsCount;

    
    public void AddCoin()
    {
        _coinsCount++;
        _coinsText.text = _coinsCount.ToString();
    }
    public void RemoveCoin()
    {
        _coinsCount = 0;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class cointcount : MonoBehaviour
{
    public static int coin;

    [SerializeField] private TextMeshProUGUI cointext;
    
    // Start is called before the first frame update
    void Start()
    {
        coin = 0;
    }

    // Update is called once per frame
    void Update()
    {
        cointext.text = "Coin:" + " " + coin;
    }
}

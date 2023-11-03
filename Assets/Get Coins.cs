using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GetCoins : MonoBehaviour
{
    public TMP_Text c_text;
    public static bool getCoin = false;

    public int coin = 0;

    private void Update()
    {
        c_text.SetText(coin.ToString());

    }
    public void PressCoin()
    {
        getCoin = true;

        coin++;
    }
}

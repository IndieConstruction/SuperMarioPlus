using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinManager : MonoBehaviour {

    Coin[] Coins;
    int coinsCollected = 0;

    private void Start() {
        Coins = FindObjectsOfType<Coin>();
    }

    public void CollectCoin() {
        coinsCollected++;
        Debug.LogFormat("== coins {0}", coinsCollected);

        if (coinsCollected == Coins.Length)
            OpenPortal();
    }

    void OpenPortal() {
        Debug.LogFormat("== open portal! {0}");
    }
}

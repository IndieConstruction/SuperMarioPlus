using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyDamageController : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        Player player = other.gameObject.GetComponent<Player>();
        if (player != null) {
            // allora è un player
            player.Damage(1);
        }
    }
}

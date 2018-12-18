using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageController : MonoBehaviour {

    public float BouncingForce = 200;

    private void OnTriggerEnter2D(Collider2D other) {
        Enemy enemy = other.gameObject.GetComponent<Enemy>();
        if (enemy != null) {
            // allora è un nemico
            enemy.Damage(1);
            Rigidbody2D rb = GetComponentInParent<Rigidbody2D>();
            rb.velocity = Vector2.zero;
            if (rb != null) {
                // faccio il rimbalzo post danneggiamento
                rb.AddForce(new Vector3(0, BouncingForce, 0));
                Debug.Log("AddForce: " + other.name);
            }
        }
    }

}

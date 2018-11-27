using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int Life;
    public float MovementSpeed;
    public int Coins;
    public float JumpForce;
    public bool isGrounded;
    public Rigidbody rb;

    private void Start()
    {
        // rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        CheckInput();
    }

    /// <summary>
    /// Controllo input movimento player
    /// </summary>
    public void CheckInput()
    {
        // Movimento laterale
        if (Input.GetKey(KeyCode.A) == true)
        { // SX
            transform.position = transform.position + new Vector3(-MovementSpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        { // DX
            transform.position = transform.position + new Vector3(+MovementSpeed, 0f, 0f);
        }

        // Salto
        if (Input.GetKeyDown(KeyCode.W) == true && isGrounded == true)
        {
            rb.AddForce(new Vector3(0, JumpForce, 0));
            // transform.position = transform.position + new Vector3(0f, JumpForce * Time.deltaTime, 0f);
            isGrounded = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Accoviacciamento");
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        //if (collision.other.tag == "Plane")
        //{
            isGrounded = true;
            Debug.Log("collide");
        //}
    }

}

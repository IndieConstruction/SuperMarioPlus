using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{

    public int Life;
    public int MovementSpeed;
    public int Coins;
    public int JumpForce;
    public bool isGrounded;
    public Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
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

        if (Input.GetKey(KeyCode.A))
        {
            transform.position = transform.position + new Vector3(-MovementSpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.position = transform.position + new Vector3(+MovementSpeed, 0f, 0f);
        }
        if (Input.GetKey(KeyCode.W) && isGrounded == true)
        {
            transform.position = transform.position + new Vector3(0f, JumpForce *Time.deltaTime, 0f);
            isGrounded = false;
        }
        if (Input.GetKey(KeyCode.S))
        {
            Debug.Log("Accoviacciamento");
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.other.tag == "Plane")
        {
            isGrounded = true;
            Debug.Log("collide");
        }
    }

}

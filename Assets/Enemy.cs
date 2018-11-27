using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour {

    public string EnemyName = "Enemy To Rename";
    public int Life = 10;
    public float MoveSpeed = 1.4f;
    private bool IsAlive = false;

	// Use this for initialization
	private void Start () {
        bool printResult = PrintString("Start enemy");
        Debug.Log("Print result: " + printResult);
    }

    // Update is called once per frame
    private void Update () {
        string tempString = "Update enemy";
        PrintString(tempString);
    }

    private bool PrintString(string stringToPrint) {
        if (EnemyName == "") {
            return false;
        } else {
            Debug.Log(stringToPrint + " : " + EnemyName);
            return true;
        }

    }

}

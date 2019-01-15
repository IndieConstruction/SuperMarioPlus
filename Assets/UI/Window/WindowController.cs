using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WindowController : MonoBehaviour {

    Animator anim;

    private void Start() {
        anim = GetComponent<Animator>();
    }

    public void Open() {
        anim.SetTrigger("Open");
    }

    public void Close() {
        anim.SetTrigger("Close");
    }

    private void Update() {
        if (Input.GetKeyDown(KeyCode.UpArrow)) {
            Open();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow)) {
            Close();
        }
    }

}

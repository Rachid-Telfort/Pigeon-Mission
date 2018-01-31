using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class MovePlayer : MonoBehaviour {

    private Rigidbody2D rb2d;

    [SerializeField]
    private float speed = 10, jumpForce = 1000;

    private void Awake() {
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void Update() {
        rb2d.AddForce(new Vector2(Input.GetAxisRaw("Horizontal"), 0).normalized * speed);
        if (Input.GetButtonDown("Space"))
            rb2d.AddForce(Vector3.up * jumpForce);
    }

}
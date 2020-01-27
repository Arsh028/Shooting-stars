using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class control : MonoBehaviour
{
    private Rigidbody2D rb;
    private float DirX;
    private float movespeed = 10f;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        DirX = CrossPlatformInputManager.GetAxis("Horizontal") * movespeed;
        rb.velocity = new Vector2(DirX, 0f);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CircelMove : MonoBehaviour
{
    public float moveSpeed = 5f;

    // Update is called once per frame
    void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        float moveY = Input.GetAxis("Vertical");
        transform.Translate(new Vector2(moveX, moveY) * moveSpeed * Time.deltaTime);

    }
}

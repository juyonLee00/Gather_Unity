using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class TopDownCharacterController : MonoBehaviour
{
    //event : 외부에서 호출 못하게 막기
    public event Action<Vector2> OnMoveEvent;
    public event Action<Vector2> OnLookEvent;

    public void CallMoveEvent(Vector2 direction)
    {
        OnMoveEvent?.Invoke(direction);
    }

    public void CallLookEvent(Vector2 direction)
    {
        OnLookEvent?.Invoke(direction);
    }

    /*
    public float speed = 5f;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        transform.position += new Vector3(x, y) * speed * Time.deltaTime;
    }*/
}

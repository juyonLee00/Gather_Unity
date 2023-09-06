using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainCameraController : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] float smoothing = 0.15f;
    private void LateUpdate()
    {
        Vector3 targetPos = new Vector3(player.position.x, player.position.y, this.transform.position.z);
        transform.position = targetPos;//Vector3.Lerp(transform.position, targetPos, smoothing);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    Transform player;
    Vector3 offset = Vector3.zero;

    private void Start()
    {
        player = GameManager.Inst.Player.transform;
        offset = transform.position - player.position;
    }

    private void LateUpdate()
    {
        transform.position = Vector3.Lerp(transform.position, player.position + offset, Time.deltaTime * 2.0f);
    }
}

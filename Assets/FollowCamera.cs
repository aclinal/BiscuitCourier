using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject followee;
    void LateUpdate()
    {
        transform.position = followee.transform.position + new Vector3(0, 0, -10);
    }
}

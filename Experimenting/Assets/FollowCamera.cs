using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowCamera : MonoBehaviour
{
    [SerializeField] GameObject thingToFollow;
    // Update is called once per frame
    private void LateUpdate() {
        transform.position = thingToFollow.transform.position + new Vector3(0, 0, -10);
    }
}

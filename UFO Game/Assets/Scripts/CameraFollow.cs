using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    Camera myCam;
    public Vector2 maxPosition;
    public Vector2 minPosition;

    // Start is called before the first frame update
    void Start()
    {
        myCam = GetComponent<Camera>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        myCam.orthographicSize = (Screen.height / 100f) / 1.5f;

        if (target)
        {
            transform.position = Vector3.Lerp(transform.position, target.position, 0.2f) + new Vector3 (0, 0, -10);
        }
    }
}

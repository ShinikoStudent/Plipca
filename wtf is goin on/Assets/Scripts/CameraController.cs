using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public Camera mainCamera;
    public Transform Character;
   // public BoxCollider2D camCharBounds;

    public float smoothSpeed = 1;

    public float cameraZoom  = -17;

    public bool verticalLock = false;
    public float verticalLockPosition = 0;

    public bool horizontalLock = false;
    public float horizontalLockPosition = 0;

   // Transform cameraPos;
    float x;
    float y;

    void FixedUpdate()
    {
        x = Character.position.x;
        y = Character.position.y;
        if (horizontalLock) x = verticalLockPosition;
        if (verticalLock) y = horizontalLockPosition;

        mainCamera.transform.position = Vector3.Lerp(mainCamera.transform.position, new Vector3(x, y, cameraZoom), smoothSpeed * Time.deltaTime);
    }
}

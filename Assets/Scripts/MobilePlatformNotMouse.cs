using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobilePlatformNotMouse : MonoBehaviour
{

    bool active;
    bool moving;
    bool isUp;
    bool isDown;
    int dir;
    public float angle;
    public float rotSpeed;

    void Update()
    {
        if (moving)
        {
            MovePlatform(dir);
        }
        if ((transform.rotation.eulerAngles.z > angle) && (!isDown))
        {
            isDown = true;
            isUp = false;
            moving = false;
        }
        if ((transform.rotation.z < 0f) && (!isUp))
        {
            isDown = false;
            isUp = true;
            moving = false;
        }
    }

    public void activePlatform()
    {
        if ((!isDown) && (!moving))
        {
            active = true;
            dir = 1;
            moving = true;
        }
        if ((!isUp) && (!moving))
        {
            active = true;
            dir = -1;
            moving = true;
        }
    }

    void MovePlatform(int dir)
    {
        transform.Rotate(Vector3.forward * (Time.deltaTime * rotSpeed * dir));
    }
}
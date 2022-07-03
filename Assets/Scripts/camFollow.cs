using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camFollow : MonoBehaviour
{
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;    
    [SerializeField] private float cameraSpeed;

    [SerializeField]
    private float mouseSensivity;
    private float mouseHorizontal, mouseVertical;

    void LateUpdate()
    {
        this.transform.position = Vector3.Lerp(this.transform.position, target.position + offset, Time.deltaTime * cameraSpeed);
        mouseHorizontal += Input.GetAxis("Mouse X") * mouseSensivity;
        mouseVertical += Input.GetAxis("Mouse Y") * mouseSensivity;
        this.transform.eulerAngles = new Vector3(-1 * mouseVertical, mouseHorizontal, 0);
        target.transform.eulerAngles = new Vector3(0, mouseHorizontal, 0);
    }
}

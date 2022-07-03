using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class jellyControl : MonoBehaviour
{
    [SerializeField] 
    private float characterSpeed;

    void FixedUpdate()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        this.gameObject.transform.Translate(horizontal * characterSpeed * Time.deltaTime, 0, vertical * characterSpeed * Time.deltaTime);
    }
}

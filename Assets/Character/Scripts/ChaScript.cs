using UnityEngine;
using System.Collections;

public class ChaScript : MonoBehaviour
{
    private Animator anim;
    [SerializeField]
    private float characterSpeed;

    void Start()
    {
        anim = GetComponent<Animator>();
        Cursor.lockState = CursorLockMode.Locked;
    }

    void Update()
    {
        CharacterControl();
        InputAndAnimator();
    }
    
    void CharacterControl()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        this.gameObject.transform.Translate(horizontal * characterSpeed * Time.deltaTime, 0,
            vertical * characterSpeed * Time.deltaTime);
    }

    void InputAndAnimator()
    {
        if (Input.GetKey(KeyCode.UpArrow) | Input.GetKey(KeyCode.W))
        {
            anim.SetBool("Run", true);
        }
        else
        {
            anim.SetBool("Run", false);
        }

        if (Input.GetKey(KeyCode.LeftArrow) | Input.GetKey(KeyCode.A))
        {
            anim.SetBool("RunLeft", true);
        }
        else
        {
            anim.SetBool("RunLeft", false);
        }

        if (Input.GetKey(KeyCode.RightArrow) | Input.GetKey(KeyCode.D))
        {
            anim.SetBool("RunRight", true);
        }
        else
        {
            anim.SetBool("RunRight", false);
        }

        if (Input.GetKey(KeyCode.DownArrow) | Input.GetKey(KeyCode.S))
        {
            anim.SetBool("RunBack", true);
        }
        else
        {
            anim.SetBool("RunBack", false);
        }

        if (Input.GetKey(KeyCode.Space))
        {
            anim.SetBool("Attack", true);
        }
        else
        {
            anim.SetBool("Attack", false);
        }
    }
}

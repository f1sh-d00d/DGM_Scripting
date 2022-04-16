using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public static PlayerController instance;
    public float moveSpeed = 5;
    private Rigidbody rb;
    private Vector3 moveInput;
    private Vector2 mouseInput;
    public float mouseSensitivity = 100.0f;
    public Camera viewCam;
    public GameObject proImpact;
    public int curAmmo;
    

    private void Awake()
    {
        instance = this;

    }

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        // hide and lock cursor
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        moveInput = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
        //uses controls set in unity to determine a new player position when a key is hit

        Vector3 moveH = transform.right * moveInput.x;
        //creates variable for x position made above. blends movement so we can move diagonal as well

        Vector3 moveV = transform.forward * moveInput.z;
        //creates variable for z positon made above

        rb.velocity = (moveH + moveV) * moveSpeed;
        //combine the two cariables and moves player to that location

        mouseInput = new Vector2(Input.GetAxis("Mouse X"), Input.GetAxis("Mouse Y")) * mouseSensitivity;
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles.x, transform.rotation.eulerAngles.y - mouseInput.x, transform.rotation.eulerAngles.z);

        if(Input.GetMouseButtonDown(0))
        {
            if (curAmmo > 0)
            {
                Ray ray = viewCam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0f));
                RaycastHit hit;

                if (Physics.Raycast(ray, out hit))
                {
                    Debug.Log("I'm looking at " + hit.transform.name);
                    Instantiate(proImpact, hit.point, transform.rotation);

                }
                else
                {
                    Debug.Log("I'm not looking at anything");
                }
            }

            curAmmo--;

        }
    }

    // >: 4 8 15 16 23 42

}

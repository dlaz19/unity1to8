using UnityEngine; 
public class MouseLook : MonoBehaviour {

    public float sensitivityHor = 9.0f;
    public float sensitivityVer = 9.0f;

    public Transform playerBody;

    float xRotation = 0f;

    void Start () {

    }
    void Update() {
        float mouseX = Input.GetAxis("Mouse X") * sensitivityHor * Time.deltaTime;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivityVer * Time.deltaTime;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);

        transform.localRotation = Quaternion.Euler(xRotation, 0f, 0f);
        playerBody.Rotate(Vector3.up * mouseX);
    }
}
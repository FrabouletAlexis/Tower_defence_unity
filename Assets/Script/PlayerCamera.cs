using UnityEngine;

public class PlayerCamera : MonoBehaviour
{
    public float _cameraSpeed = 2.0f;

    private float cameraSpeed {get { return _cameraSpeed; } }

    private Transform cameraTransform { get; set; } = null;

    public float _borderSize = 10.0f;

    private float borderSize {get { return _borderSize; } }

    private const float deadZone = 0.9f;

    private void Start()
    {
        cameraTransform = GetComponent<Transform>();
    }

    private void Update()
    {
        Vector3 mousePos = Input.mousePosition;

        Vector3 direction = Vector3.zero;

        //Debug.Log(Time.deltaTime);

        if (mousePos.x < borderSize || Input.GetAxis("Horizontal") < -deadZone)
        {
            direction += Vector3.left;
        }
        else if (mousePos.x >= Screen.width - borderSize || Input.GetAxis("Horizontal") > deadZone)
        {
            direction += Vector3.right;
        }

        if (mousePos.y < borderSize || Input.GetAxis("Vertical") < -deadZone)
        {
            direction += Vector3.back;
        }
        else if (mousePos.y >= Screen.height - borderSize || Input.GetAxis("Vertical") > deadZone)
        {
            direction += Vector3.forward;
        }

        direction.Normalize();
        cameraTransform.position += direction * Time.deltaTime * cameraSpeed;    }
}

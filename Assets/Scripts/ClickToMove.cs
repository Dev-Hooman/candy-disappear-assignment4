using UnityEngine;

public class ClickToMove : MonoBehaviour
{
    private Camera cam;
    private Vector3 targetPosition;
    public static bool isMoving;

    void Start()
    {
        cam = Camera.main;
        isMoving = false;
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) && !isMoving)
        {
            targetPosition = cam.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, cam.nearClipPlane));
            targetPosition.z = 0f;

            Vector3 direction = targetPosition - transform.position;
            Quaternion rotation = Quaternion.LookRotation(Vector3.forward, direction);
            transform.rotation = rotation;

            isMoving = true;
        }

        if (isMoving)
        {
            transform.position = Vector3.MoveTowards(transform.position, targetPosition, 0.02f);

            if (transform.position == targetPosition)
            {
                isMoving = false;
            }
        }
    }

    public static void ResetMovement()
    {
        isMoving = false;
    }
}

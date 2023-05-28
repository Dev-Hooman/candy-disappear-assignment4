using UnityEngine;

public class HandleCollision : MonoBehaviour
{
    public GameObject candy1;
    public GameObject candy2;
    public GameObject candy3;
    public GameObject candy4;

    public Vector3 customBottomLeftPosition;
    public Vector3 customBottomRightPosition;
    public Vector3 customTopLeftPosition;
    public Vector3 customTopRightPosition;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject == candy1
            || collision.gameObject == candy2
            || collision.gameObject == candy3
            || collision.gameObject == candy4)
        {
            SoundManager.playObjectDisappearSound();

            candy1.transform.position = customBottomLeftPosition;
            candy2.transform.position = customBottomRightPosition;
            candy3.transform.position = customTopLeftPosition;
            candy4.transform.position = customTopRightPosition;

            ClickToMove.ResetMovement();
        }
    }
}

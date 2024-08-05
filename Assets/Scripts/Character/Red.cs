using UnityEngine;

public class Red : MonoBehaviour
{
    [SerializeField] private float movementSpeed;

    private Vector2 cachedDir;

    private void Update()
    {
        var horizontal = Input.GetAxisRaw("Horizontal");
        var vertical = Input.GetAxisRaw("Vertical");

        horizontal = cachedDir.y != 0 ? 0 : horizontal;
        vertical = cachedDir.x != 0 ? 0 : vertical;
        cachedDir = new Vector2(horizontal, vertical);
        if (horizontal != 0 || vertical != 0)
        {
            transform.Translate(cachedDir * (movementSpeed * Time.deltaTime));
        }
    }
}
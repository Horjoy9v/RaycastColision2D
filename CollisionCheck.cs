using UnityEngine;

public class CollisionCheck : MonoBehaviour
{

    public static bool isGround(Vector3 position, float distance)
    {
        RaycastHit2D hit = Physics2D.Raycast(position, Vector2.down, distance, LayerMask.GetMask("Ground"));
        Debug.DrawRay(position, Vector2.down * distance, Color.red);

        if (hit.collider == null)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
    
    public static bool isWall(Vector3 position, float distance)
    {
        RaycastHit2D hit = Physics2D.Raycast(position, Vector2.right, distance, LayerMask.GetMask("Wall"));
        Debug.DrawRay(position, Vector2.right * distance, Color.red);

        if (hit.collider == null)
        {
            return false;
        }
        else
        {
            Debug.Log("Hit object: " + hit.collider.gameObject.name);
            return true;
        }
    }
}

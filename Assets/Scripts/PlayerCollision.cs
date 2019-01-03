 using UnityEngine;

public class PlayerCollision : MonoBehaviour {

    public PlayerMovement movement;
    public Vector3 collisionPoint;

    void OnCollisionEnter(Collision collisionInfo)
    {
        if(collisionInfo.collider.tag == "Obstacle")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

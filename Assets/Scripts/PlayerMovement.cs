using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public Rigidbody rb;
    public float fowardForce = 2000f;
    public float sideForce = 500f;

	// Prefers "FixedUpdate" over "Update" for calculating physics
	void FixedUpdate ()
    {
        rb.AddForce(0, 0, fowardForce  * Time.deltaTime); // Time.deltaTime is to allow the the force be applied accross all computers
        if(Input.GetKey("d"))
        {
            rb.AddForce(sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if (Input.GetKey("a"))
        {
            rb.AddForce(-sideForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }
        if(rb.position.y < 0f)
        {
            FindObjectOfType<GameManager>().EndGame();
        }
    }
}

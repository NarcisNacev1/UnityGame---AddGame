using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardForce = 2000f;// moving forward force
    public float SideWaysForce = 500f;// moving sideways force

    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void FixedUpdate() { // use FixedUpdate to mess with physics witch is better for unity when doing physics
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d")) {
            rb.AddForce(SideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        } else if (Input.GetKey("a")) {
            rb.AddForce(-SideWaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
        }

        if (rb.position.y < -1f) {
        FindAnyObjectByType<GameManagerS1>().EndGame();        
        }
    }
}

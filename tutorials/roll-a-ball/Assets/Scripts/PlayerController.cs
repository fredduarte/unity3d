using UnityEngine;

public class PlayerController : MonoBehaviour {

    public float speed;
    private Rigidbody mRigidbody;

    void Start() {
        mRigidbody = GetComponent<Rigidbody>();
    }

    void FixedUpdate() {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        mRigidbody.AddForce(movement * speed);
    }
}

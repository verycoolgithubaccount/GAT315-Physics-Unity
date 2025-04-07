using UnityEngine;

public class ClothController : MonoBehaviour
{
    [SerializeField] float speed = 1.0f;
    [SerializeField] float jumpHeight = 2.0f;
    [SerializeField] LayerMask colliderLayer = Physics.AllLayers;

    Rigidbody rb;
    Vector3 force;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        Vector3 direction = Vector3.zero;

        direction.x = Input.GetAxis("Horizontal");
        direction.z = Input.GetAxis("Vertical");

        force = direction * speed;

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(Vector3.up * Mathf.Sqrt(-2 * Physics.gravity.y * jumpHeight), ForceMode.Impulse);
        }
    }

    private void FixedUpdate()
    {
        rb.AddForce(force, ForceMode.Force);
        // rb.AddTorque(Vector3.up);
    }
}
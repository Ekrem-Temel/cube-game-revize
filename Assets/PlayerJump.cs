using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    public float jumpForce = 5f; // Z�plama kuvveti
    public Transform groundCheck; // Yer kontrol� i�in Transform
    public float groundDistance = 0.4f; // Yer kontrol� i�in yar��ap
    public LayerMask groundMask; // Yer olarak kabul edilecek katmanlar

    private Rigidbody rb;
    private bool isGrounded;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Update()
    {
        // Yerde mi kontrol et
        isGrounded = Physics.CheckSphere(groundCheck.position, groundDistance, groundMask);

        // Z�plama kontrol�
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            rb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
        }
    }
}

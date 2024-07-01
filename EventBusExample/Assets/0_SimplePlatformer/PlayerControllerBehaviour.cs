using UnityEngine;

namespace _0_SimplePlatformer
{
    public class PlayerControllerBehaviour : MonoBehaviour
    {
        [SerializeField] private Rigidbody2D rigidbody2D;
        [SerializeField] private SpriteRenderer spriteRenderer;
        [SerializeField] private float movementSpeed = 5;
        [SerializeField] private float jumpForce = 10;
        private bool _queuedJump;

        private void Update()
        {
            // flip sprite
            var horizontal = Input.GetAxis("Horizontal");
            if (horizontal < -0.1f) spriteRenderer.flipX = true;
            else if (horizontal > 0.1f) spriteRenderer.flipX = false;
        
            // jump input
            var isStandingOrFalling = rigidbody2D.velocity.y < 0.01f;
            if (isStandingOrFalling) _queuedJump |= Input.GetButtonDown("Jump");
        }

        private void FixedUpdate()
        {
            // movement physics
            rigidbody2D.velocity = new Vector2(Input.GetAxis("Horizontal") * movementSpeed, rigidbody2D.velocity.y);
        
            // jump physics
            if (_queuedJump && Mathf.Abs(rigidbody2D.velocity.y) < 0.1f)
            {
                rigidbody2D.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
                _queuedJump = false;
            }
        }
    }
}

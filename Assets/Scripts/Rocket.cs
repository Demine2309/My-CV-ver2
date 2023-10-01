using UnityEngine;
using UnityEngine.SceneManagement;

public class Rocket : MonoBehaviour
{
    private float gravity;
    private Rigidbody2D rb;
    private Vector2 startPos;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        startPos = transform.position;
        gravity = rb.gravityScale;
    }

    private void Update()
    {
        Vector2 vec = rb.velocity;

        float ang = Mathf.Atan2(vec.y, 10) * Mathf.Rad2Deg;
        transform.root.rotation = Quaternion.Euler(new Vector3(0,0,ang - 90));

        if(Input.GetKey(KeyCode.Space))
        {
            rb.AddForce(Vector2.up * gravity * Time.deltaTime * 2000f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Bound") || collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("Game1");
        }
    }
}

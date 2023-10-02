using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Meteorite : MonoBehaviour
{
    [SerializeField] private float moveSpeed;
    //[SerializeField] private float rotateSpeed;

    private void Update()
    {
        //transform.Rotate(new Vector3 (0, 0, rotateSpeed * Time.deltaTime));
        transform.Translate(Vector3.left * moveSpeed * Time.deltaTime);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Bound"))
        {
            gameObject.GetComponent<Collider2D>().enabled = false;
        }

        if (collision.gameObject.CompareTag("FinishObj"))
        {
            Destroy(this.gameObject);
        }
    }
}

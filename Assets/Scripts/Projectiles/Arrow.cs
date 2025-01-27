using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    [Header("Config")]
    [SerializeField] [Range(10f, 40f)] private float _speed = 10f;

    private Rigidbody2D _rb;

    private void Awake()
    {
        this._rb = GetComponent<Rigidbody2D>();
    }

    // Start is called before the first frame update
    void Start()
    {
        this._rb.velocity = this.transform.right * this._speed;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag.Equals("Garbage"))
        {
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MobHorizontal : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed;
    public float length;
    private float counter;
    private float startPosition;

    private float actualPosition;
    private float lastPosition;

    public bool horizontal;

    void Start()
    {
        if (horizontal)
        {
            startPosition = transform.position.x;
        }
        else
        {
            startPosition = transform.position.y;
        }
    }
    void Update()
    {
        counter += Time.deltaTime * speed;
        if (horizontal)
        {
            transform.position = new Vector2(Mathf.PingPong(counter, length) + startPosition, transform.position.y);
            actualPosition = transform.position.x;
            if (actualPosition < lastPosition) gameObject.GetComponent<SpriteRenderer>().flipX = false;
            if (actualPosition > lastPosition) gameObject.GetComponent<SpriteRenderer>().flipX = true;
            lastPosition = transform.position.x;
        }
        else
        {
            transform.position = new Vector2(transform.position.x, Mathf.PingPong(counter, length) + startPosition);
        }
    }

}

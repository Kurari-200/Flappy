using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : MonoBehaviour
{
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //space�L�[����͂�����W�����v
        if (Input.GetKeyDown("space"))
        {
            //�d�͂ɗ͂�������
            rb.AddForce(new Vector2(0, 8), ForceMode2D.Impulse);//����0�A����8�@impulse���u�ԓI�ɗ͂�������B
        }
    }
}

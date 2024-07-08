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
        //spaceキーを入力したらジャンプ
        if (Input.GetKeyDown("space"))
        {
            //重力に力を加える
            rb.AddForce(new Vector2(0, 8), ForceMode2D.Impulse);//ｘに0、ｙに8　impulse→瞬間的に力を加える。
        }
    }
}

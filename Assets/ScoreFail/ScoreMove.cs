using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*AddScore関数内にて、scoreにpointだけ加算し、
 Text型の変数textobjの文字列変数textにその数値を反映させています。*/
public class ScoreMove : MonoBehaviour
{
    //スコアを表示するテキストUI
    [SerializeField] Text scoreText;
    // スコアを管理する変数
    private int score = 0;

    private void Update()
    {
        //スコアをUIに表示
        scoreText.text = score.ToString();
    }

    // リングにプレイヤーが接触した際に呼ばれる関数
    private void OnTriggerEnter2D(Collider2D other)
    {
        // プレイヤーオブジェクトとの接触であるかを判定
        if (other.CompareTag("Player"))
        {
            // プレイヤーのY軸速度が正かどうかで上から入ったか下から入ったかを判定
            Rigidbody2D playerRb = other.GetComponent<Rigidbody2D>();
            if (playerRb.velocity.y > 0)
            {
                // 上から入った場合、スコアを1増やす
                score++;
                
                Debug.Log("Score: " + score);
            }
            // 下から入った場合は何もしない（スコアは増やさない）
        }
    }
}

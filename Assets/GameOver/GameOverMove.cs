using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMove : MonoBehaviour
{
    public float gameOverYPosition = -3.51f; // ゲームオーバーのY座標

    private bool isGameOver = false;

    void Update()
    {
        // ゲームオーバーでない場合のみ処理を行う
        if (!isGameOver)
        {
            // ゲームオーバーのY座標に到達したらゲームオーバー処理を呼び出す
            if (transform.position.y <= gameOverYPosition)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        // ゲームオーバー時の処理を記述する
        // 例：ゲームオーバー画面を表示する、リスタート処理を行う、スコアをリセットするなど
        SceneManager.LoadScene("Game Over"); // "Game Over" シーンをロードする
        isGameOver = true;
    }
}

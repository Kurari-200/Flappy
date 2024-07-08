using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMove : MonoBehaviour
{
    public float gameOverYPosition = -3.51f; // �Q�[���I�[�o�[��Y���W

    private bool isGameOver = false;

    void Update()
    {
        // �Q�[���I�[�o�[�łȂ��ꍇ�̂ݏ������s��
        if (!isGameOver)
        {
            // �Q�[���I�[�o�[��Y���W�ɓ��B������Q�[���I�[�o�[�������Ăяo��
            if (transform.position.y <= gameOverYPosition)
            {
                GameOver();
            }
        }
    }

    void GameOver()
    {
        // �Q�[���I�[�o�[���̏������L�q����
        // ��F�Q�[���I�[�o�[��ʂ�\������A���X�^�[�g�������s���A�X�R�A�����Z�b�g����Ȃ�
        SceneManager.LoadScene("Game Over"); // "Game Over" �V�[�������[�h����
        isGameOver = true;
    }
}

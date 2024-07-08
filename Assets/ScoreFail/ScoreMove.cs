using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/*AddScore�֐����ɂāAscore��point�������Z���A
 Text�^�̕ϐ�textobj�̕�����ϐ�text�ɂ��̐��l�𔽉f�����Ă��܂��B*/
public class ScoreMove : MonoBehaviour
{
    //�X�R�A��\������e�L�X�gUI
    [SerializeField] Text scoreText;
    // �X�R�A���Ǘ�����ϐ�
    private int score = 0;

    private void Update()
    {
        //�X�R�A��UI�ɕ\��
        scoreText.text = score.ToString();
    }

    // �����O�Ƀv���C���[���ڐG�����ۂɌĂ΂��֐�
    private void OnTriggerEnter2D(Collider2D other)
    {
        // �v���C���[�I�u�W�F�N�g�Ƃ̐ڐG�ł��邩�𔻒�
        if (other.CompareTag("Player"))
        {
            // �v���C���[��Y�����x�������ǂ����ŏォ�����������������������𔻒�
            Rigidbody2D playerRb = other.GetComponent<Rigidbody2D>();
            if (playerRb.velocity.y > 0)
            {
                // �ォ��������ꍇ�A�X�R�A��1���₷
                score++;
                
                Debug.Log("Score: " + score);
            }
            // ������������ꍇ�͉������Ȃ��i�X�R�A�͑��₳�Ȃ��j
        }
    }
}

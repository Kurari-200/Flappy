using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //�Q�[���J�n���ɌĂяo�����
    void Awake()
    {
        /*�C�x���g��'OnGoalPostEvent'���\�b�h���T�u�X�N���C�u���܂��B
         * �܂�A�S�[���|�X�g�C�x���g�����������ۂ�'OnGoalpostEvent'���\�b�h���Ăяo�����悤�ɂȂ�܂��B*/
        GameEvents.OnGoalPostEvent += OnGoalPostEvent;
    }

    //�I�u�W�F�N�g���j�������Ƃ��ɌĂяo�����B
    void OnDestroy()
    {
        //
        GameEvents.OnGoalPostEvent -= OnGoalPostEvent;
    }

    void OnGoalPostEvent()
    {
        Debug.Log(" Goal�����I ");
    }
}

using UnityEngine;

/*���ݓI�Ȗ��_�Ƃ��āA'OnCollisioEnter'���\�b�h��'MonoBehaviour'�ɏ]�����Ă��邱�Ƃ��m�F�ł���B
 * ����́A3D�����ł�'Collision'���A2D�����ł́A'Collision2D'���g�p���܂��B
 * �����'Rifidbody2D'���g���Ă��邽�߁A'Collision'��'Collision2D'�ɕύX����K�v������܂��B*/

public class GoalPostController : MonoBehaviour
{
    [Header(" Elements ")]
    //�S�[���I�u�W�F�N�g��Prefab
    [SerializeField] GameObject goalPrefab;
    //�S�[���C�x���g���g���K�[����I�u�W�F�N�g�̃^�O��
    [SerializeField] Transform createGoalPostTransform;

    [Header(" Settings ")]
    //�S�[���|�X�g�̈ړ����x
    [SerializeField] string targetTagName;
    [SerializeField] Vector3 moveSpeed;
    //'rd'�F�S�[���I�u�W�F�N�g��rigidbody�R���|�[�l���g
    Rigidbody2D rd;

    void Start()
    {
        // �����ݒ�
        //'goalPrefab'���w�肳�ꂽ'createGoalPostTransform'�̈ʒu�ɃC���X�^���X�����܂��B
        var a = Instantiate(goalPrefab, createGoalPostTransform);
        //�C���X�^���X�����ꂽ�I�u�W�F�N�g��'rigidbody'�R���|�[�l���g���擾���܂��B
        rd = a.GetComponent<Rigidbody2D>();
    }

    //���t���[�����ƂɁA'moveSpeed'�Ɋ�Â���'Rigidbody'('rd')�ɗ͂������܂��B
    void FixedUpdate()
    {
        rd.AddForce(moveSpeed * Time.deltaTime);
    }

    //�Փ˂����I�u�W�F�N�g�̃^�O��'targetTagName'�ƈ�v����ꍇ'OnGoalPostEvent'�f���Q�[�g���Ăяo��
    //�܂��i����null�łȂ���΁j
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == targetTagName)
            GameEvents.OnGoalPostEvent?.Invoke();
    }
}


using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject goalPrefab;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(AppearanceGoal), 0f, 5f);
        //invokeRepeating�����x���J��Ԃ��������s�킹��@�������J�n��O�b��ɕ\���A���̂T�b��Ɏ��̏�����\���B

    }

    // Update is called once per frame
    void Update()
    {
        //x���ɃX�N���[��
        transform.position += new Vector3(2 * Time.deltaTime, 0, 0);
    }

    //�S�[���|�X�g���W�w��
    private void AppearanceGoal()
    {
        //randoAppearance�̂����ɓ����B
        Vector2 randoAppearance = new Vector2(
            transform.position.x + 8,
            Random.Range(-3f, 3f));
        //�S�[���̕\���@��]�Ȃ�
        Instantiate(goalPrefab,randoAppearance,Quaternion.identity);
    }
}

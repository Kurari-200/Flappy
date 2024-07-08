using UnityEngine;

/*潜在的な問題点として、'OnCollisioEnter'メソッドが'MonoBehaviour'に従がっていることを確認できる。
 * これは、3D物理では'Collision'を、2D物理では、'Collision2D'を使用します。
 * 今回は'Rifidbody2D'を使っているため、'Collision'を'Collision2D'に変更する必要があります。*/

public class GoalPostController : MonoBehaviour
{
    [Header(" Elements ")]
    //ゴールオブジェクトのPrefab
    [SerializeField] GameObject goalPrefab;
    //ゴールイベントをトリガーするオブジェクトのタグ名
    [SerializeField] Transform createGoalPostTransform;

    [Header(" Settings ")]
    //ゴールポストの移動速度
    [SerializeField] string targetTagName;
    [SerializeField] Vector3 moveSpeed;
    //'rd'：ゴールオブジェクトのrigidbodyコンポーネント
    Rigidbody2D rd;

    void Start()
    {
        // 初期設定
        //'goalPrefab'を指定された'createGoalPostTransform'の位置にインスタンス化します。
        var a = Instantiate(goalPrefab, createGoalPostTransform);
        //インスタンス化されたオブジェクトの'rigidbody'コンポーネントを取得します。
        rd = a.GetComponent<Rigidbody2D>();
    }

    //毎フレームごとに、'moveSpeed'に基づいて'Rigidbody'('rd')に力を加えます。
    void FixedUpdate()
    {
        rd.AddForce(moveSpeed * Time.deltaTime);
    }

    //衝突したオブジェクトのタグが'targetTagName'と一致する場合'OnGoalPostEvent'デリゲートを呼び出し
    //ます（もしnullでなければ）
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == targetTagName)
            GameEvents.OnGoalPostEvent?.Invoke();
    }
}

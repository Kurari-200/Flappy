
using UnityEngine;

public class Move : MonoBehaviour
{
    public GameObject goalPrefab;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating(nameof(AppearanceGoal), 0f, 5f);
        //invokeRepeating→何度も繰り返し処理を行わせる　処理が開始後０秒後に表示、その５秒後に次の処理を表示。

    }

    // Update is called once per frame
    void Update()
    {
        //x軸にスクロール
        transform.position += new Vector3(2 * Time.deltaTime, 0, 0);
    }

    //ゴールポスト座標指定
    private void AppearanceGoal()
    {
        //randoAppearanceのｙ軸に入れる。
        Vector2 randoAppearance = new Vector2(
            transform.position.x + 8,
            Random.Range(-3f, 3f));
        //ゴールの表示　回転なし
        Instantiate(goalPrefab,randoAppearance,Quaternion.identity);
    }
}

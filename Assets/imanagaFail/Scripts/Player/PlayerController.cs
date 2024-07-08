using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //ゲーム開始時に呼び出される
    void Awake()
    {
        /*イベントに'OnGoalPostEvent'メソッドをサブスクライブします。
         * つまり、ゴールポストイベントが発生した際に'OnGoalpostEvent'メソッドが呼び出されるようになります。*/
        GameEvents.OnGoalPostEvent += OnGoalPostEvent;
    }

    //オブジェクトが破棄されるときに呼び出される。
    void OnDestroy()
    {
        //
        GameEvents.OnGoalPostEvent -= OnGoalPostEvent;
    }

    void OnGoalPostEvent()
    {
        Debug.Log(" Goalした！ ");
    }
}

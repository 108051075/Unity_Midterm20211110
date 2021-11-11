using UnityEngine;

/// <summary>
/// 學習運算子
/// 1. 指定 =
/// 2. 數學 + - * / %  遞增 ++ 遞減 --
/// 3. 比較
/// 4. 邏輯
/// </summary>
public class LeamOperator : MonoBehaviour
{
    #region 指定運算子
    // 指定運算子特性:
    // ※ 指定運算子先執行右邊在指定給左邊
    // 1 + 2 = 3
    public int number = 10;     // 指定:將數字 10 指定給欄位 number

    public float numberA = 10;
    public float numberB = 3;
    public int numberC = 30;
    #endregion

    private void Start()
    {
        #region 數學運算子
        print("加法:" + (numberA + numberB));
        print("減法:" + (numberA - numberB));
        print("乘法:" + (numberA * numberB));
        print("除法:" + (numberA / numberB));
        print("餘法:" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC 減 1:" + numberC);
        numberC--;                           // 遞減
        print("numberC 減 1:" + numberC);
        #endregion
    }
}

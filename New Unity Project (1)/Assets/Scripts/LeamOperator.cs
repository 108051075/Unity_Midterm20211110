using UnityEngine;

/// <summary>
/// �ǲ߹B��l
/// 1. ���w =
/// 2. �ƾ� + - * / %  ���W ++ ���� --
/// 3. ���
/// 4. �޿�
/// </summary>
public class LeamOperator : MonoBehaviour
{
    #region ���w�B��l
    // ���w�B��l�S��:
    // �� ���w�B��l������k��b���w������
    // 1 + 2 = 3
    public int number = 10;     // ���w:�N�Ʀr 10 ���w����� number

    public float numberA = 10;
    public float numberB = 3;
    public int numberC = 30;
    #endregion

    private void Start()
    {
        #region �ƾǹB��l
        print("�[�k:" + (numberA + numberB));
        print("��k:" + (numberA - numberB));
        print("���k:" + (numberA * numberB));
        print("���k:" + (numberA / numberB));
        print("�l�k:" + (numberA % numberB));

        numberC = numberC - 1;
        print("numberC �� 1:" + numberC);
        numberC--;                           // ����
        print("numberC �� 1:" + numberC);
        #endregion
    }
}

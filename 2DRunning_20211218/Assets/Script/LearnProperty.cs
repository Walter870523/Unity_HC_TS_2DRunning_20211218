using UnityEngine;


/// <summary>
/// �ǲ��ݩ� Property
/// </summary>
public class LearnProperty : MonoBehaviour
{
    // ���ݩʻy�k
    // ���� ������� �ݩʦW�� {�s���l}
    // �ֳt���� prop + TAB * 2
    // get ���o
    // set �s��
    public int lv { get; set; }

    public string passwordField;

    // C# �̷s 10 ��
    // Unity �w�] 7 ��
    // �߿W�ݩ�
    // �߿W�����Ȫ��y�k: get => �� ;
    // => �H�ڹF Lambda
    public string passswordProperty { get => "777"; }

    private void Start()
    {
        // �s���ݩ� set
        lv = 100;
        // ���o�ݩ� get
        print("����:" + lv);

        // �s�����
        passwordField = "1234567";
        print("���o���K�X : " + passwordField);

        // �s���ݩ�
        // passswordProperty = "1234567";        // �߿W�ݩʤ�����w��
        print("���o�ݩʱK�X: " + passswordProperty);
    }
}
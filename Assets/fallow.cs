using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallow : MonoBehaviour
{
    public Transform t;    //������һ���ŷ��ݵ���
    Vector3 o;             //���������
    // Start is called before the first frame update
    void Start()
    {
        o = transform.position - t.position;  //����Ϸ��������ʱ��ȷ�������ߵĳ��ȡ��������Ϣ
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = t.position + o;  //��ÿʱÿ�̷��ݶ����˺���������
    }
}

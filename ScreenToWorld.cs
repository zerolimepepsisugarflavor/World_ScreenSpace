using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenToWorld : MonoBehaviour
{
    public GameObject prefab;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // 0 == ��Ŭ��
        {
            Ray rar = Camera.main.ScreenPointToRay(Input.mousePosition); // ���� ī�޶󿡼� Ŭ���� ��ġ���� ������ ��� �Լ�
            RaycastHit hit;
            if (Physics.Raycast(rar, out hit))
            {
                Instantiate(prefab, hit.point, Quaternion.identity);
                //�ν��Ͻ�ȭ ������ ��ü ���콺 ���� ��ġ , Quaternion �̿�/ .indentity == ���ʹϾ� �̿�� ȸ�� x �Ҷ�
            }
        }
    }
}

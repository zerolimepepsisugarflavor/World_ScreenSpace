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
        if (Input.GetMouseButtonDown(0)) // 0 == 좌클릭
        {
            Ray rar = Camera.main.ScreenPointToRay(Input.mousePosition); // 메인 카메라에서 클릭한 위치까지 광선을 쏘는 함수
            RaycastHit hit;
            if (Physics.Raycast(rar, out hit))
            {
                Instantiate(prefab, hit.point, Quaternion.identity);
                //인스턴스화 프리펩 객체 마우스 현재 위치 , Quaternion 이용/ .indentity == 쿼터니언 이용시 회전 x 할때
            }
        }
    }
}

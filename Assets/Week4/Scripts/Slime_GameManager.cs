using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_GameManager : MonoBehaviour
{
    void Start()
    {
        Slime aa = new Slime("꾸꾸", 100, 20, 5); // 슬라임 꾸꾸 객체 생성
        Slime bb = new Slime("무무", 100, 10, 10); // 슬라임 무무 객체 생성

        while(true) // 한 슬라임이 죽을 때까지 반복
        {
            aa.Attack(bb); // 꾸꾸가 무무를 공격!
            if(bb.IsDead()) // 무무가 죽었는지 확인
                break;
            bb.Attack(aa); //무무가 꾸꾸를 공격!
            if(aa.IsDead()) // 꾸꾸가 죽었는지 확인
                break;
        }
    }
}

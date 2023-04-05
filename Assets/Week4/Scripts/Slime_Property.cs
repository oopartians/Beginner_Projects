using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeProp
{
    // 필드
    private string name { get; }
    private string type { get; }
    private int hp { get; set; }
    private int atk { get; }
    private int dfs { get; }
    
    //생성자
    public SlimeProp(string _name, int _hp, int _atk, int _dfs)
    {
        name = _name;
        type = "slime"; // type은 어차피 슬라임이기 때문에 매개변수로 받지 않았습니다.
        hp = _hp;
        atk = _atk;
        dfs = _dfs;
    }

    // getter, setter 삭제

    // 메서드들
    public void Attack(SlimeProp enemy){
        Debug.Log($"{name}은(는) {enemy.name}을(를) 공격했다!");
        int damage = atk - enemy.dfs;
        enemy.hp -= damage;
        Debug.Log($"{enemy.name}은(는) {damage}의 피해를 입고 체력이 {enemy.hp}가 되었습니다.");
    }

    public bool IsDead(){
        if(hp <= 0)
        {
            Debug.Log($"{name}은(는) 죽었습니다...");
            return true;
        }
        else return false;
    }

}
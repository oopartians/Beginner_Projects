using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeProp
{
    // 필드 + 자동완성 프로퍼티
    public string name { get; }
    public string type { get; }
    public int hp { get; set; }
    public int atk { get; }
    public int dfs { get; }
    
    //생성자
    public SlimeProp(string _name, int _hp, int _atk, int _dfs)
    {
        name = _name;
        type = "slime"; // type은 어차피 슬라임이기 때문에 매개변수로 받지 않았습니다.
        hp = _hp;
        atk = _atk;
        dfs = _dfs;
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
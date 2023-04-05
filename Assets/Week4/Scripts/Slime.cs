using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime
{
    // 필드
    private string name;
    private string type;
    private int hp;
    private int atk;
    private int dfs;
    
    //생성자
    public Slime(string _name, int _hp, int _atk, int _dfs)
    {
        name = _name;
        type = "slime"; // type은 어차피 슬라임이기 때문에 매개변수로 받지 않았습니다.
        hp = _hp;
        atk = _atk;
        dfs = _dfs;
    }

    // getter, setter
    public string getName() { return name; }

    public string getType() { return type; } // name, type은 변경하면 안되기 때문에 getter만 만들어 줍니다.

    public int gethp() { return hp; }
    public void sethp(int _hp) { hp = _hp; }

    public int getatk() { return atk; }
    public void setatk(int _atk) { atk = _atk; }

    public int getdfs() { return dfs; }
    public void setdfs(int _dfs) { dfs = _dfs; }

    // 메서드들
    public void Attack(Slime enemy){
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
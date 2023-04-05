using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Slime_GameManager : MonoBehaviour
{
    public GameObject Green;
    public GameObject Red;

    public GameObject GreenHpBar;
    public GameObject RedHpBar;

    Animator animGreen;
    Animator animRed;

    Vector3 InitialGreenPos;
    Vector3 InitialRedPos;

    SlimeProp GG;
    SlimeProp RR;

    public GameObject pfDamagePopup;

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

// 아래는 스파게티 코드들
        RR = new SlimeProp("Red", 50, 20, 5); // 슬라임 Red 객체 생성
        GG = new SlimeProp("Green", 50, 10, 10); // 슬라임 Green 객체 생성
        animGreen = Green.GetComponent<Animator>();
        animRed =  Red.GetComponent<Animator>();
        InitialGreenPos = Green.transform.position;
        InitialRedPos = Red.transform.position;
    }

    // 메서드들
    public void Attack(SlimeProp attacker, SlimeProp enemy){
        Debug.Log($"{attacker.name}은(는) {enemy.name}을(를) 공격했다!");
        int damage = attacker.atk - enemy.dfs;
        enemy.hp -= damage;
        GameObject damagePopup;
        if(enemy.name == "Red")
        {
            damagePopup = Instantiate(pfDamagePopup, Red.transform.position + new Vector3(1, 3, 0), Quaternion.identity);
            DamagePopup dp = damagePopup.GetComponent<DamagePopup>();
            dp.SetDamage(damage);
        }
        else if(enemy.name == "Green")
        {
            damagePopup = Instantiate(pfDamagePopup, Green.transform.position + new Vector3(-1, 3, 0), Quaternion.identity);
            DamagePopup dp = damagePopup.GetComponent<DamagePopup>();
            dp.SetDamage(damage);
        }
        // HPBar event
        Debug.Log($"{enemy.name}은(는) {damage}의 피해를 입고 체력이 {enemy.hp}가 되었습니다.");
    }

    public void AttackRed()
    {
        StartCoroutine(GreenToRed());
    }

    public void AttackGreen()
    {
        StartCoroutine(RedToGreen());
    }

    IEnumerator WaitForIt(float time)
    {
        yield return new WaitForSeconds(time);
    }

    IEnumerator GreenToRed()
    {
        while(true)
        {
            Green.transform.position -= new Vector3(0.05f, 0, 0);
            var distance = Vector3.Distance(Green.transform.position, Red.transform.position);
            if(distance <= 4)
            {
                animGreen.Play("Green_Move");
                break;
            }
            yield return null;
        }
        yield return new WaitForSeconds(2f);
        Attack(GG, RR);
        RedHpBar.transform.localScale = new Vector3(((float)RR.hp / 50f) * 0.4f, .05f, 1);
        if(RR.IsDead())
        {
            animRed.Play("Green_Die");
        }
        animGreen.Play("Green_Idle");
        while(true)
        {
            SpriteRenderer sr = Green.GetComponent<SpriteRenderer>();
            sr.flipX = true;
            Green.transform.position += new Vector3(0.03f, 0, 0);
            var distance = Vector3.Distance(Green.transform.position, InitialGreenPos);
            if(distance <= 0.1f)
            {
                Green.transform.position = InitialGreenPos;
                sr.flipX = false;
                break;
            }
            yield return null;
        }
    }

    IEnumerator RedToGreen()
    {
        while(true)
        {
            Red.transform.position += new Vector3(0.05f, 0, 0);
            var distance = Vector3.Distance(Red.transform.position, Green.transform.position);
            if(distance <= 4)
            {
                animRed.Play("Green_Move");
                break;
            }
            yield return null;
        }
        yield return new WaitForSeconds(2f);
        Attack(RR, GG);
        GreenHpBar.transform.localScale = new Vector3(((float)GG.hp / 50f) * 0.4f, .05f, 1);
        if(GG.IsDead())
        {
            animGreen.Play("Green_Die");
        }
        animRed.Play("Green_Idle");
        while(true)
        {
            SpriteRenderer sr = Red.GetComponent<SpriteRenderer>();
            sr.flipX = false;
            Red.transform.position -= new Vector3(0.03f, 0, 0);
            var distance = Vector3.Distance(Red.transform.position, InitialRedPos);
            if(distance <= 0.1f)
            {
                Red.transform.position = InitialRedPos;
                sr.flipX = true;
                break;
            }
            yield return null;
        }
    }
}

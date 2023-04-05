using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopup : MonoBehaviour
{
    public static DamagePopup Create(Vector3 position, int damageAmount)
    {
        GameObject _go = Resources.Load("Week4/Prefabs/pfDamagePopup") as GameObject;
        GameObject go = Instantiate(_go, position, Quaternion.identity) ;
        Transform popUpDamageTransform = go.transform;

        DamagePopup popUpDamage = popUpDamageTransform.GetComponent<DamagePopup>();
        popUpDamage.SetDamage(damageAmount);

        return popUpDamage;
    }

    private TextMeshPro text;
    private float disappearTimer;
    private Color textColor;

    
    private void Awake()
    {
        text = GetComponent<TextMeshPro>();
    }

    public void SetDamage(int damageAmount)
    {
        text.SetText(damageAmount.ToString());
        textColor = text.color;
        disappearTimer = 1f;
    }

    private void Update()
    {
        // Animation으로 처리 해도 좋다! (결국 하는 행동은 같다)
        float moveSpeedY = .5f;
        transform.position += new Vector3(0, moveSpeedY) * Time.deltaTime;

        disappearTimer -= Time.deltaTime;
        if (disappearTimer < 0f)
        {
            float disappearSpeed = 3f;
            textColor.a -= disappearSpeed * Time.deltaTime;
            text.color = textColor;
            if (textColor.a < 0f) Destroy(gameObject);
        }
    }
}

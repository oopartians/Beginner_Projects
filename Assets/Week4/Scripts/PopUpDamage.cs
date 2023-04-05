using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DamagePopup : MonoBehaviour
{
    public static DamagePopup Create(Vector3 position, int damageAmount)
    {
        Transform popUpDamageTransform = Instantiate(GameAssets.instance.pfDamagePopup, position, Quaternion.identity);

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
        float moveSpeedY = 20f;
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

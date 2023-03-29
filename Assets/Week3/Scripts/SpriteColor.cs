using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpriteColor : MonoBehaviour
{
    SpriteRenderer myRenderer;

    public string color;

    float time = 0;
    // Start is called before the first frame update
    void Start()
    {
        myRenderer = gameObject.GetComponent<SpriteRenderer>();
        if (color == "red") myRenderer.color = Color.red;
        else if (color == "blue") myRenderer.color = Color.blue;
        else myRenderer.color = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime; // The interval in seconds from the last frame to the current one (Read Only).
        if (time >= 3)
        {
            Color randomColor = Random.ColorHSV();
            myRenderer.color = randomColor;
            time = 0;   // Reset time
        }
        // Or use Coroutine (we will handle this later)
    }

    public void ChangeColor(GameObject go)
    {
        SpriteRenderer rendererGO = go.GetComponent<SpriteRenderer>();

        Color randomColor = Random.ColorHSV();
        rendererGO.color = randomColor;
    }
}

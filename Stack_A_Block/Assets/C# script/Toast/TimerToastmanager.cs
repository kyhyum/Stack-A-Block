using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerToastmanager : MonoBehaviour
{
    private Text txt;
    private float fadeInOutTime = 0.3f;
    private static TimerToastmanager instance = null;

    public static TimerToastmanager Instrance
    {
        get
        {
            if (null == instance) return null;
            return instance;
        }
    }

    private void Awake()
    {
        if (null == instance) instance = this;
    }
    // Start is called before the first frame update
    void Start()
    {
        txt = this.gameObject.GetComponent<Text>();
        txt.enabled = false;
    }

    private IEnumerator fadeInOut(Text target, float durationTime, bool inOut)
    {
        float start, end;
        if (inOut)
        {
            start = 0.0f;
            end = 1.0f;
        }
        else
        {
            start = 1.0f;
            end = 0f;
        }

        Color current = Color.clear; /* (0, 0, 0, 0) = 검은색 글자, 투명도 100% */
        float elapsedTime = 0.0f;

        while (elapsedTime < durationTime)
        {
            float alpha = Mathf.Lerp(start, end, elapsedTime / durationTime);

            target.color = new Color(current.r, current.g, current.b, alpha);
            
            elapsedTime += Time.deltaTime;

            yield return null;
        }
    }

     private IEnumerator showMessageCoroutine(string msg, float durationTime)
    {
        Color originalColor = txt.color;
        txt.text = msg;
        txt.enabled = true;

        yield return fadeInOut(txt, fadeInOutTime, true);

        float elapsedTime = 0.0f;
        while(elapsedTime < durationTime)
        {
            elapsedTime += Time.deltaTime;
            yield return null;
        }

        yield return fadeInOut(txt, fadeInOutTime, false);

        txt.enabled = false;
        txt.color = originalColor;
    }

       public void showMessage(string msg, float durationTime)
    {
        StartCoroutine(showMessageCoroutine(msg,durationTime));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

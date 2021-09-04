using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DayNightCycle : MonoBehaviour
{
    public Light sunLight, dedicatedLight, playerLight;
    [SerializeField]
    float duration;
    float t = 0;
    public bool startCycle = false;
    public Text text;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(CycleStart());
    }

    // Update is called once per frame
    void Update()
    {
        if (startCycle)
        {
            t += Time.deltaTime / duration;
            sunLight.intensity = Mathf.Lerp(0.9f, 0.05f, t);
            sunLight.color = Color.Lerp(new Color32(193, 203, 217, 255), new Color32(255, 42, 0, 255), t);
            if(sunLight.intensity == 0.5f)
            {
                RenderSettings.ambientIntensity = Mathf.Lerp(1, 0.3f, t);
            }
        }

        if(sunLight.intensity >= 0.25f)
        {
            dedicatedLight.enabled = true;
            playerLight.enabled = true;
        }else if (sunLight.intensity <= 0.25f)
        {
            dedicatedLight.enabled = false;
            playerLight.enabled = false;
        }
        text.text = "" + t;
    }

    IEnumerator CycleStart()
    {
        yield return new WaitForSeconds(20f);
        startCycle = true;
    }


}

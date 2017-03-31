using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    public GameObject player;
    public Material BG, titleBG;
    public float start, end;

    private float fade = 1f;

	void Update ()
    {
		if (player.transform.position.z >= start && player.transform.position.z <= end)
        {
            if (BG.color.a < 0.7)
                BG.color = new Color(BG.color.r, BG.color.g, BG.color.b, BG.color.a + (fade * Time.deltaTime));
            if (titleBG.color.a < 1)
                titleBG.color = new Color(titleBG.color.r, titleBG.color.g, titleBG.color.b, titleBG.color.a + (fade * Time.deltaTime));
        }
        else
        {
            if (BG.color.a > 0.5)
                BG.color = new Color(BG.color.r, BG.color.g, BG.color.b, BG.color.a - (fade * Time.deltaTime));
            if (titleBG.color.a > 0.8)
                titleBG.color = new Color(titleBG.color.r, titleBG.color.g, titleBG.color.b, titleBG.color.a - (fade * Time.deltaTime));
        }
    }
}

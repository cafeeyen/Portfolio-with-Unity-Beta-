using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ImageChanger : MonoBehaviour
{
    public SpriteRenderer[] spriteArray;
    public Transform player;
    public int start, end;

    private int cnt = 0, size;
    private bool working = false;
    private IEnumerator coroutine;

    void Start()
    {
        size = spriteArray.Length;
        coroutine = changeImage();
    }

    void Update()
    {
        if (player.position.z >= start && player.position.z <= end && !working)
        {
            StartCoroutine(coroutine);
            working = true;
        }
        else if (player.position.z < start || player.position.z > end)
        {
            StopCoroutine(coroutine);
            working = false;
        }
    }

    IEnumerator changeImage()
    {
        while(true)
        {
            if (spriteArray[(cnt + 1) % size].color.a < 1)
            {
                spriteArray[cnt % size].color = new Color(spriteArray[cnt % size].color.r, spriteArray[cnt % size].color.g, spriteArray[cnt % size].color.b, spriteArray[cnt % size].color.a - Time.deltaTime);
                spriteArray[(cnt + 1) % size].color = new Color(spriteArray[(cnt + 1) % size].color.r, spriteArray[(cnt + 1) % size].color.g, spriteArray[(cnt + 1) % size].color.b, spriteArray[(cnt + 1) % size].color.a + Time.deltaTime);
                yield return new WaitForSeconds(0.01f);
            }
            else
            {
                cnt++;
                yield return new WaitForSeconds(2f);
            }
        }
    }
}

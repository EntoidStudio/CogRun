using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] GameObject[] bg;
    [SerializeField] GameObject bgFlash;

    bool bgChange = true;
    private void FixedUpdate()
    {
        if (Time.time > 5 && bgChange)            
        {
            bgChange = false;
            BgChangingFlash();
            bg[0].SetActive(false);
            bg[1].SetActive(true);
        }
        if (bgFlash != null)
        {
            if (bgFlash.GetComponent<SpriteRenderer>().color.a > 0)
            {
                var color = bgFlash.GetComponent<SpriteRenderer>().color;
                color.a -= 0.01f;

                bgFlash.GetComponent<SpriteRenderer>().color = color;
            }
        }


    }

    void BgChangingFlash()
    {
        var color = bgFlash.GetComponent<SpriteRenderer>().color;
        color.a = 0.8f;

        bgFlash.GetComponent<SpriteRenderer>().color = color;
    }
}

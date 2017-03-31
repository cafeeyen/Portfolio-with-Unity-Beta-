using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextController : MonoBehaviour
{
    public Transform player;
    public Text text;

	
	// Update is called once per frame
	void Update ()
    {
        if (player.position.z >= 2130 && player.position.z <= 2330)
            text.text = "Little sheep go through enemies and obstacles for moji. \n"
                + "\" Moon rabbit's moji is the best! \"";

        else if (player.position.z >= 2380 && player.position.z <= 2580)
            text.text = "Walk into field and capture it, get score and win! \n"
                + "\" That field is my! \"";

        else if (player.position.z >= 2630 && player.position.z <= 2910)
            text.text = "Update news in KMITL from everywhere. \n"
                + "Scan QR code from poster and navigate to target.";

        else
            text.text = "";
	}
}

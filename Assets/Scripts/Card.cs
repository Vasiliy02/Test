using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Card : MonoBehaviour
{
    [SerializeField]
    private RawImage rawImage;

    public float rotateZ;

    public int ammountHp;
    public int ammountAttack;
    public int ammountMana;

    public Text textHp;
    public Text textAttack;
    public Text textMana;

    private IEnumerator Start()
    {
        print("Downloading from the web");
        WWW www = new WWW("https://picsum.photos/200/300");
        yield return www;
        Texture2D texture = www.texture;
        rawImage.texture = texture;
        transform.Rotate(0f, 0f, rotateZ);
    }

    private void Update()
    {
        textHp.text = "" + ammountHp;
        textAttack.text = "" + ammountAttack;
        textMana.text = "" + ammountMana;
    }

    public void HandTap()
    {
        ammountAttack -= Random.Range(1,9);
        ammountHp -= Random.Range(1, 9);
        ammountMana -= Random.Range(1, 9);

        if(ammountAttack <= 0)
        {
            Destroy(gameObject);
        }

        if (ammountHp <= 0)
        {
            Destroy(gameObject);
        }

        if (ammountMana <= 0)
        {
            Destroy(gameObject);
        }
    }

}


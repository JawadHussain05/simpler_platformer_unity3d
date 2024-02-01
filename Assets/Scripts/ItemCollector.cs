using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    [SerializeField] private Text cherriesText;
    [SerializeField] private Text heartText;
    private int cherries = 0;
    private int hearts = 0;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            cherriesText.text = ": "+ cherries;
        }

        if (collision.gameObject.CompareTag("heart"))
        {
            Destroy(collision.gameObject);
            hearts++;
            heartText.text = ": "+ hearts;
        }

    }
}

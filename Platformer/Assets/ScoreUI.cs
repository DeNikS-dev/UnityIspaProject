using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreUI : MonoBehaviour
{
    public UnityEngine.UI.Text GoldDisplay;
    public float gold = 0;
    public float GiveGold = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "DiamondBonus")
        {
            gold += GiveGold;
            GoldDisplay.text = $"Score: {gold}";
            Destroy(collision.gameObject);
        }
    }

}

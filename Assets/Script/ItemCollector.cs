using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ItemCollector : MonoBehaviour
{
    private int cherries = 0;
    UIManager m_ui;

    [SerializeField] private Text cherriesText;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Cherry"))
        {
            Destroy(collision.gameObject);
            cherries++;
            m_ui = FindObjectOfType<UIManager>();
            m_ui.SetScoreText("cherries:" + cherries);
        }
    }
    public void SetScore(int value)
    {
        cherries = value;
    }
    public int GetScore()
    {
        return cherries;
    }
    public void IncrementScore()
    {
        cherries++;
        m_ui.SetScoreText("Score:" + cherries);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintFieldScript : MonoBehaviour
{
    [SerializeField]
    private GameObject[] paints;
    [SerializeField]
    private GameObject[] fields;
    private Color color;
    private Color defaultColor = Color.white;
    
    private void OnMouseDown()
    {
        for (int i=0; i<paints.Length; i++)
        {
            if (gameObject == paints[i])
            {
                PlayerPrefs.SetInt("paintIndex", i);

            }
            

        }
        foreach (GameObject field in fields)
        {
            if (gameObject==field)
            {
                int j = PlayerPrefs.GetInt("paintIndex");
                gameObject.GetComponent<SpriteRenderer>().color = paints[j].GetComponent<SpriteRenderer>().color;
            }
        }
        

    }

    private void Start()
    {
        color = defaultColor;
    }



}

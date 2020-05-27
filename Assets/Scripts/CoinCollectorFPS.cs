using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CoinCollectorFPS : MonoBehaviour {

    /// кількість зібраних кубів
    private int count;
    /// Початкова кількість кубів
    private int countCoub;
    /// текстові поля
    public Text countText, winText, leftText;

	// Use this for initialization
	void Start () {
        count = 0;
        // по замовчуванням зібрано 0 кубів        
        winText.text = ""; //текст перемоги по замовчуванням прихований
        /// отримуємо кількість елементів з тегом cubes        
        countCoub = GameObject.FindGameObjectsWithTag("cubes").Length;
        setCount();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "cubes")
        {
            Destroy(other.gameObject);
            count++;
            setCount();
        }
    }

    private void setCount()
    {
        countText.text = " Кількість :" + count.ToString();
        int cubesLeft = countCoub - count;
        leftText.text = " Залишилось :" + cubesLeft.ToString();
        if (count >= countCoub)
            winText.text = " Перемога !!!";
    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineFruits : MonoBehaviour
{
    [SerializeField] public string fruitKinds;//フルーツの種類
    [SerializeField] private GameObject combinedFruit;//できあがる先のフルーツのプレハブを記録
    
    //衝突したときにフルーツの合成を行う
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))                         // Fruitタグに接触したとき
        {
            if (collision.gameObject.GetComponent<CombineFruits>().fruitKinds == fruitKinds) {//同じfruitKindsのフルーツなら
                Instantiate(combinedFruit, this.transform.position, this.transform.rotation);
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                    }
        }
    }
}

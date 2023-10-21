using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CombineFruits : MonoBehaviour
{
    [SerializeField] public string fruitKinds;//�t���[�c�̎��
    [SerializeField] private GameObject combinedFruit;//�ł��������̃t���[�c�̃v���n�u���L�^
    
    //�Փ˂����Ƃ��Ƀt���[�c�̍������s��
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Fruit"))                         // Fruit�^�O�ɐڐG�����Ƃ�
        {
            if (collision.gameObject.GetComponent<CombineFruits>().fruitKinds == fruitKinds) {//����fruitKinds�̃t���[�c�Ȃ�
                Instantiate(combinedFruit, this.transform.position, this.transform.rotation);
                Destroy(collision.gameObject);
                Destroy(this.gameObject);
                    }
        }
    }
}

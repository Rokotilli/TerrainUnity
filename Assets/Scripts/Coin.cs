using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Coin : MonoBehaviour
{   
    [SerializeField] private TextMeshProUGUI textMeshProUGUI;
    [SerializeField] private float rotationSpeed = 5.0f;

    void Update()
    {
        transform.Rotate(Vector3.right, rotationSpeed * Time.deltaTime);
    }
    
    void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        textMeshProUGUI.text = (float.Parse(textMeshProUGUI.text) + 1f).ToString();
    }
}
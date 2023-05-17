using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Drawmanager : MonoBehaviour
{
        [SerializeField] 
        public Line _linePrefab;

    
        private Line _currentLine;// Храненим текущую линию
        
        private void Update()
        {
            // В mousePosition записываем мировые координаты
            Vector2 mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);

            //При нажатии кнопки создается новый _linePrefab в позиции mousePosition.
            if (Input.GetMouseButtonDown(0))
            {
                _currentLine = Instantiate(_linePrefab, mousePosition, Quaternion.identity);
            }
            //  При удерживает кнопки  вызывается метод SetPosition(), который устанавливает конечную точку линии равной mousePosition.
            if (Input.GetMouseButton(0))
            {
                _currentLine.SetPosition(mousePosition);
            }
        }
}

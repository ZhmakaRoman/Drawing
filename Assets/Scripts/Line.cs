using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Line : MonoBehaviour
{
    [SerializeField]
    private LineRenderer _lineRenderer;

    //метод добавляет точку в конец линии
    public void SetPosition(Vector2 position)
    {
        if (!CanAppend(position))//проверка показывает, что нельзя добавить координату, то метод просто выходит. 
        {
            return;
        }
        //Tckb можно добавить координату, то метод увеличивает количество позиций линии на один 
        _lineRenderer.positionCount++;
        _lineRenderer.SetPosition(_lineRenderer.positionCount-1,position);
    }

     //Метод определить, нужно ли добавить новую точку в линию
    private bool CanAppend(Vector2 position)
    {
       const float  minDistance = 0.1f;
        if (_lineRenderer.positionCount == 0)//Если количество точек в линии равно 0 то будет True
        {
            return true;
        }
//Vector2.Distance вычисляется расстояние между последней добавленной точкой и текущей
//Если это расстояние меньше чем minDistance, то добавление точки невозможно и метод возвращает false.
//Если же расстояние между точками больше minDistance, то добавление точки возможно и метод возвращает true
        return Vector2.Distance(_lineRenderer.GetPosition(_lineRenderer.positionCount - 1), position) >
              minDistance;

    }
}

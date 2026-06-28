using System.Collections.Generic;
using UnityEngine;
using static UnityEditor.Progress;

public class ArraysAndList : MonoBehaviour
{
    private int[] _numbers = new int[5];
    public List<int> numbers;
    //private List<int> numbers = new List<int>(); 
    void Start()
    {
        _numbers[0] = 1;
        _numbers[1] = 6;
        _numbers[2] = 22;
        _numbers[3] = 44;
        _numbers[4] = 12;

        /*foreach (var item in _numbers)
        {
            print(item);
        }
        for (int i = 0; i < _numbers.Length; i++)
        {
            print(_numbers[i]);
        }*/

        numbers.Add(7);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            numbers.Add(Random.Range(0, 100));
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            numbers.RemoveAt(numbers.Count - 1);
        }
    }
}

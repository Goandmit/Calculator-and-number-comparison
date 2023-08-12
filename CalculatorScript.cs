using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CalculatorScript : MonoBehaviour
{
    [SerializeField] private Text _resultNumberText;
    [SerializeField] private Text _arithmeticOperationSignText;
    [SerializeField] private InputField _firstNumberField;
    [SerializeField] private InputField _secondNumberField;

    float _firstNumber;    
    float _secondNumber;    
    
    public void Addition()
    {
        if (string.IsNullOrEmpty(_firstNumberField.text) || string.IsNullOrEmpty(_secondNumberField.text))
        {
            _resultNumberText.text = "¬ведите два числа";           
        }
        else
        {
            _firstNumber = float.Parse(_firstNumberField.text);
            _secondNumber = float.Parse(_secondNumberField.text);
            _resultNumberText.text = (_firstNumber + _secondNumber).ToString();
            _arithmeticOperationSignText.text = "+";
        }
    }

    public void Subtraction()
    {
        if (string.IsNullOrEmpty(_firstNumberField.text) || string.IsNullOrEmpty(_secondNumberField.text))
        {
            _resultNumberText.text = "¬ведите два числа";
        }
        else
        {
            _firstNumber = float.Parse(_firstNumberField.text);
            _secondNumber = float.Parse(_secondNumberField.text);
            _resultNumberText.text = (_firstNumber - _secondNumber).ToString();
            _arithmeticOperationSignText.text = "-";
        }
    }

    public void Multiplication()
    {
        if (string.IsNullOrEmpty(_firstNumberField.text) || string.IsNullOrEmpty(_secondNumberField.text))
        {
            _resultNumberText.text = "¬ведите два числа";
        }
        else
        {
            _firstNumber = float.Parse(_firstNumberField.text);
            _secondNumber = float.Parse(_secondNumberField.text);
            _resultNumberText.text = (_firstNumber * _secondNumber).ToString();
            _arithmeticOperationSignText.text = "*";
        }
    }

    public void Division()
    {
        if (string.IsNullOrEmpty(_firstNumberField.text) || string.IsNullOrEmpty(_secondNumberField.text))
        {
            _resultNumberText.text = "¬ведите два числа";
        }
        else
        {
            _firstNumber = float.Parse(_firstNumberField.text);
            _secondNumber = float.Parse(_secondNumberField.text);
            _resultNumberText.text = (_firstNumber / _secondNumber).ToString();
            _arithmeticOperationSignText.text = "/";
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class СomparisonScript : MonoBehaviour
{    
    [SerializeField] private Text _resultNumberText;
    [SerializeField] private Text _versusSignText;
    [SerializeField] private InputField _firstNumberField;
    [SerializeField] private InputField _secondNumberField;

    float _firstNumber;
    float _secondNumber;  
    
    public void СomparisonLargest()
    {
        if (string.IsNullOrEmpty(_firstNumberField.text) || string.IsNullOrEmpty(_secondNumberField.text))
        {
            _resultNumberText.text = "Введите два числа";
        }
        else
        {
            _firstNumber = float.Parse(_firstNumberField.text);
            _secondNumber = float.Parse(_secondNumberField.text);

            if (_firstNumber > _secondNumber)
            {
                _resultNumberText.text = _firstNumber.ToString();
                _versusSignText.text = ">";
            }
            else if (_firstNumber < _secondNumber)
            {
                _resultNumberText.text = _secondNumber.ToString();
                _versusSignText.text = "<";
            }
            else
            {
                _resultNumberText.text = "Числа равны";
                _versusSignText.text = "=";
            }
        }        
    }

    public void СomparisonSmallest()
    {
        if (string.IsNullOrEmpty(_firstNumberField.text) || string.IsNullOrEmpty(_secondNumberField.text))
        {
            _resultNumberText.text = "Введите два числа";
        }
        else
        {
            _firstNumber = float.Parse(_firstNumberField.text);
            _secondNumber = float.Parse(_secondNumberField.text);

            if (_firstNumber < _secondNumber)
            {
                _resultNumberText.text = _firstNumber.ToString();
                _versusSignText.text = "<";

            }
            else if (_firstNumber > _secondNumber)
            {
                _resultNumberText.text = _secondNumber.ToString();
                _versusSignText.text = ">";
            }
            else
            {
                _resultNumberText.text = "Числа равны";
                _versusSignText.text = "=";
            }
        }        
    }
}

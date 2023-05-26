namespace Enumerator;
using System;
using System.Collections;

public class Enumeratorx : IEnumerable
{
    private string[] _fruits;

    public Enumeratorx()
    {
        _fruits = new string[] { "Apple", "Banana", "Cherry" };
    }

    public IEnumerator GetEnumerator()
    {
        return new FruitEnumerator(_fruits);
    }

    // class dalam class
    private class FruitEnumerator : IEnumerator
    {
        private string[] _fruits;
        private int _currentIndex;

        public FruitEnumerator(string[] fruits)
        {
            this._fruits = fruits;
            _currentIndex = -1;
        }

        public object Current => _fruits[_currentIndex];

        public bool MoveNext()
        {
            _currentIndex++;
            return _currentIndex < _fruits.Length;
        }

        public void Reset()
        {
            _currentIndex = -1;
        }
    }
}
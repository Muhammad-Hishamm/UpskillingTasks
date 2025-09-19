using System;
using System.Collections;
using System.Collections.Generic;

public class EvenNumberCollection : IEnumerable<int>
{
    private readonly List<int> _numbers;

    public EvenNumberCollection(List<int> numbers)
    {
        _numbers = numbers ;
    }

    public IEnumerator<int> GetEnumerator()
    {
        foreach (var number in _numbers)
        {
            if (number % 2 == 0)
                yield return number;
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }



    /*

public class EvenNumberCollection : IEnumerable<int>
{
    private  List<int> _numbers;

    public EvenNumberCollection(List<int> numbers)
    {
        _numbers = numbers ;
    }

    public IEnumerator<int> GetEnumerator()
    {
        return new EvenNumberEnumerator(_numbers);
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    private class EvenNumberEnumerator : IEnumerator<int>
    {
        List<int> _numbers;
        int _position = -1;

        public EvenNumberEnumerator(List<int> numbers)
        {
            _numbers = numbers;
        }

        public int Current => _numbers[_position];

        object IEnumerator.Current => Current;

        public bool MoveNext()
        {
            while (++_position < _numbers.Count)
            {
                if (_numbers[_position] % 2 == 0)
                    return true;
            }
            return false;
        }

        public void Reset()
        {
            _position = -1;
        }

    }
}
     * */
}
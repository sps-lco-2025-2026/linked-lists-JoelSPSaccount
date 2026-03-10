using System.Runtime.InteropServices;

namespace LinkedListIntroduction.Lib;

public class IntegerLinkedList
{
    IntegerNode _head;
   
    public IntegerLinkedList()
    {
        _head = null;
    }

    public IntegerLinkedList(int v)
    {
        _head = new IntegerNode(v);
    }

    public int Count => _head == null ? 0 : _head.Count;
    public int Sum => _head == null ? 0 : _head.Sum;

    public void Append(int v)
    {
        if (_head == null)
            _head = new IntegerNode(v);
        else
            _head.Append(v);

    }

    public void Prepend(int v)
    {
        _head = new IntegerNode(v, _head);
    }
    
    internal bool Delete(int v)
    {
        if (_head == null) return false;
        else if (_head._value == v) 
        {
            _head = _head._next;
            return true;
        }
        else return _head.Delete(v);
    }

    public override string ToString()
    {
        return _head == null ? "{}" : $"{{{_head}}}";
    }
    public void Reverse()
    {
        if (_head == null) return;
        _head = _head.Reverse();
    }
    bool void Insert(int v, int i)
    {
        if (_head == null) {
        if (i = 0) {_head = new IntegerNode(v); return true;}
        else return false;}
        else return false;
    }
}

public class IntegerNode
{
    int _value;
    IntegerNode _next;

    internal int Count => _next == null ? 1 : 1 + _next.Count;
            
    internal int Sum => _next == null ? _value : _value + _next.Sum;


    internal IntegerNode(int v)
    {
        _value = v;
        _next = null;
    }

    internal void Append(int v)
    {
        if (_next == null)
            _next = new IntegerNode(v);
        else
            _next.Append(v);
    }

    internal bool Delete(int v)
    {
        if (_next == null) return false;
        else if (_next._value == v) 
        {
            _next = _next._next;
            return true;
        }
        else return _next.Delete(v);
    }

    public override string ToString()
    {
        return _next == null ? _value.ToString() : $"{_value}, {_next}";
    }

    internal void Reverse(IntegerNode? last = null)
    {
        IntegerNode newNode = new IntegerNode(v, last);
        if (_next == null)
            return newNode;
        else return Reverse(newNode);
    }

    internal void Insert(int v, int i)
    {
        
    }

}

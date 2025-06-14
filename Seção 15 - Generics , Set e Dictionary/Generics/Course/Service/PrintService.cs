using System;


namespace Course.Service
{
    // Generaliza a classe <Qualquer letra> 
    internal class PrintService<A>
    {
       
        public A[] _values = new A[10];
        
        public int _count = 0; 

        

        public void AddValue(A value)
        {
            if(_count == 10)
            {
                throw new InvalidOperationException("The vector is already full");
            }
            _values[_count] = value;
            _count++;
        }

        public A First()
        {
            return _values[0];
        }

        public void Print()
        {
            Console.Write("[ ");
            for(int i = 0; i < _count - 1; i++)
            {
                Console.Write(_values[i] + ", ");
            }
            
            if (_count >  0 ) 
            {
                Console.Write(_values[_count - 1]);
            }
            Console.WriteLine(" ]");
        }
    }
}

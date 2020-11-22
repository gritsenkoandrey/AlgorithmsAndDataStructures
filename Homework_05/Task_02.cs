namespace Homework_05
{
    class MyStack<T>
    {
        private T[] stek;
        private int header;

        public bool IsEmpty { get; private set; }
        public bool IsFull { get; private set; }

        public MyStack(int length = 64)
        {
            stek = new T[length];
            header = -1;
            IsEmpty = true;
            IsFull = false;
        }

        public bool Push(T obj)
        {
            if (!IsFull)
            {
                stek[++header] = obj;
                if (header == stek.Length - 1) IsFull = true;
                IsEmpty = false;
                return true;
            }
            else
            {
                throw new System.StackOverflowException("StackOverflow");
            }
        }

        public T Pop()
        {
            T value = default;
            if (!IsEmpty)
            {
                value = stek[header--];
                if (header < 0) IsEmpty = true;
            }
            return value;
        }

        public T Peek()
        {
            T value = default;
            if (!IsEmpty) value = stek[header];
            return value;
        }

        public void Clear()
        {
            header = -1;
            IsEmpty = true;
            IsFull = false;
        }

        public override string ToString()
        {
            string result = string.Empty;
            int position = 1;
            if (IsEmpty) return "Stack is empty!";
            else
            {
                for (int i = header; i >= 0; i--)
                {
                    result += string.Format($"\n{position} => {stek[i]}");
                    position++;
                }
            }
            return result;
        }
    }
}
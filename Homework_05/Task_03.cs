namespace Homework_05
{
    class Task_03
    {
        static MyStack<char> stack = new MyStack<char>();

        public static bool IsCorrect(string str)
        {
            foreach (char ch in str)
            {
                if (ch == '(' || ch == '{' || ch == '[') stack.Push(ch);
                else if (ch == ')' || ch == '}' || ch == ']')
                {
                    switch (ch)
                    {
                        case ')':
                            if (stack.Peek() == '(') stack.Pop();
                            else { stack.Clear(); return false; }
                            break;
                        case '}':
                            if (stack.Peek() == '{') stack.Pop();
                            else { stack.Clear(); return false; }
                            break;
                        case ']':
                            if (stack.Peek() == '[') stack.Pop();
                            else { stack.Clear(); return false; }
                            break;
                    }
                }
            }
            return stack.IsEmpty;
        }
    }
}
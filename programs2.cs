//Функция Аккермана — это математическая функция, которая является примером рекурсивно определенной вычислительной задачи.
//Она названа в честь немецкого математика Вильгельма Аккермана.
//Функция Аккермана обычно обозначается как A(m, n) и определяется следующим образом:

//1.Если m = 0, то A(m, n) = n + 1.
//2.Если m > 0 и n = 0, то A(m, n) = A(m-1, 1).
//3. Если m > 0 и n > 0, то A(m, n) = A(m-1, A(m, n - 1)).

//Функция Аккермана растет очень быстро с увеличением значений m и n,
//что делает ее трудной для эффективного вычисления для больших входных значений. 
//Она служит важным примером рекурсивной функции, способной продемонстрировать мощность и ограничения рекурсии в программировании.



using System;


class Program
{
    static void Main()
    {
        int m = 2; // первое число
        int n = 1; // второе число

        int result = AckermannFunction(m, n);
        Console.WriteLine($"Ackermann({m}, {n}) = {result}");
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
        {
            return n + 1;
        }
        else if (n == 0)
        {
            return AckermannFunction(m - 1, 1);
        }
        else
        {
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));
        }
    }
}

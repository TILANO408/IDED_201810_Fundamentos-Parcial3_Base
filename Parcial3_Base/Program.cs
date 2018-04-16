using System;

namespace Parcial3_Base
{
    public struct Centro
    {
        public float X { get; private set; }
        public float Y { get; private set; }

        public Centro(float x, float y)
        {
            X = x;
            Y = y;
        }
    }

    public class Program
    {
        private static void Main(string[] args)
        {
            //Puede usar este main para probar sus métodos.
            Program myProgram = new Program();

            Program palin = new Program();
            string input = string.Empty;
            palin.EsPalindromo(input);

            Console.WriteLine("Presione Enter para salir");
            Console.ReadLine();
        }

        #region EASY

        // VALOR DE LOS SIGUIENTES NUMERALES: 0.5 / 5.0

        /// <summary>
        /// Determina si dos matrices pueden sumarse
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>'true' si las matrices pueden sumarse, 'false' de otro modo</returns>
        public bool SePuedenSumarMatrices(int[,] A, int[,] B)

        {

            bool valor = false;
            if (A.GetLength(0) == B.GetLength(0) && A.GetLength(1) == B.GetLength(1))
            {


                valor = true;


            }
            else { valor = false; }



            return valor;
        }

        /// <summary>
        /// Retorna el promedio aritmético de los elementos en  arr
        /// </summary>
        /// <param name="arr"></param>
        /// <returns></returns>
        public float PromedioDeArreglo(int[] arr)
        {
            float promedio = 0f;
            int sumatotal = 0;
            int totalelementos = arr.Length;
            for (int i = 0; i < arr.Length; i++)
            {


                sumatotal = sumatotal + arr[i];

            }

            promedio = sumatotal / totalelementos;

            return promedio;
        }

        /// <summary>
        /// Determina cuántas veces aparece char en input
        /// </summary>
        /// <param name="input"></param>
        /// <param name="car"></param>
        /// <returns>La cantidad de veces que aparece char en input</returns>
        public int ConteoDeCaracter(string input, char car)
        {
            int contador = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == car)
                {

                    contador += 1;

                }


            }







            return contador;
        }

        #endregion EASY

        #region MEDIUM

        // VALOR DE LOS SIGUIENTES NUMERALES: 1.0 / 5.0

        /// <summary>
        /// Retorna otro arreglo cuyos elementos tengan los mismos que arr, pero con orden invertido.
        /// </summary>
        /// <param name="arr"></param>
        /// <returns>Un arreglo cuyos elementos están en orden inverso a arr</returns>
        public int[] InvertirArreglo(int[] arr)
        {

            return null;

        }

        /// <summary>
        /// Determina si un string es palíndromo
        /// Un palíndromo es una palabra que se escribe igual al derecho y al revés
        /// </summary>
        /// <param name="input"></param>
        /// <returns>'true' si input es palíndromo, `false` de otro modo</returns>
        public bool EsPalindromo(string input)
        {
            bool valor = true;

            string input2 = "";



            for (int i = input.Length; i < input.Length - 1; i--)
            {




                input2 += input[i]; 


            }

            if (input == input2)
            { valor = true; }
            else { valor = false; }


            return valor;



        }

        /// <summary>
        /// Calcula el n-ésimo término de la serie de Fibonacci, basado en índice 0
        /// </summary>
        /// <param name="n"></param>
        /// <returns>El número correspondiente a la posición n en la serie de Fibonacci</returns>
        public int CalcularFibonacciEn(int n)
        {
            int resultado = 1;
            int x = 1;
            int y = 0;
            if (n == 0) { resultado = 0; }
            if (n == 1) { resultado = 1; }
            if (n >= 2)
            {
                for (int i = 2; i <= n; i++)
                {
                    resultado = x + y;
                    y = x;
                    x = resultado;


                }
                

            }







            return resultado;
        }

        /// <summary>
        /// Retorna la matriz resultada de multiplicar A x B, si es posible hacer la operación.
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns>La matriz AxB</returns>
        public int[,] MultiplicarMatrices(int[,] A, int[,] B)
        {
            int[,] resultado = new int[A.GetLength(0), B.GetLength(1)];
            if (A.GetLength(1) == B.GetLength(1))
            {

                for (int i = 0; i < A.GetLength(0); i++)
                {

                    for (int j = 0; j < A.GetLength(1); j++)
                    {
                        for (int k = 0; k < B.GetLength(1); k++)
                        {


                            resultado[i, j] += A[i, k] * B[k, j];


                        }



                    }



                }




            }

            

            return resultado;

        }

        #endregion MEDIUM

        #region HARD

        //VALOR DE LOS SIGUIENTES NUMERALES: 1.5 / 5.0

        /// <summary>
        ///  Devuelve un string que indique cuántas horas, minutos y segundos hay dada la cantidad total de segundos
        ///  Recuerde: 1 hr = 3600 segs.
        /// </summary>
        /// <param name="totalSegs"></param>
        /// <returns>Un string indicando cuántas horas, minutos y segundos hay en totalSegs</returns>
        public string FormatearTiempo(int totalSegs)
        {
            int hrs = 0;
            int mins = 0;
            int segs = 0;

            

                while (totalSegs >= 3600)
                {
                    totalSegs = totalSegs - 3600;
                    hrs = hrs + 1;

                }

                while (totalSegs >= 60)
                {

                    totalSegs = totalSegs - 60;
                    mins = mins + 1;

                }

            segs = totalSegs;
            

            return string.Format("{0} hrs : {1} mins : {2} segs", hrs, mins, segs);
        }

        /// <summary>
        /// Determina si dos circunferencias se tocan en algún punto, dados sus radios y centros.
        /// Recuerde, la distancia entre dos puntos está dada por la fórmula
        /// d^2 = [(x2 - x1)^2] + [(y2 - y1)^2]
        /// </summary>
        /// <param name="c1">El centro de la primera circunferencia</param>
        /// <param name="r1">El radio de la primera circunferencia</param>
        /// <param name="c2">El centro de la segunda circunferencia</param>
        /// <param name="r2">El radio de la segunda circunferencia</param>
        /// <returns>'true' si hay algún punto en que las esferas se toquen, 'false' de otro modo</returns>
        public bool HayColisión(Centro c1, float r1, Centro c2, float r2)
        {
            return false;
        }

        /// <summary>
        /// Determina el próximo número que sea primo a mayor que n
        /// </summary>
        /// <param name="n"></param>
        /// <returns>El primer número primo mayor que n</returns>
        public int ProximoPrimo(int n)
        {
            return 0;
        }

        /// <summary>
        /// Combina los elementos de dos matrices A y B de dimensiones iguales,
        /// de manera que los elementos de la diagonal sean
        /// los elementos de la diagonal de A, y el resto los de B
        /// </summary>
        /// <param name="A"></param>
        /// <param name="B"></param>
        /// <returns></returns>
        public int[,] CombinaMatrices(int[,] A, int[,] B)
        {
            return null;
        }

        #endregion HARD
    }
}
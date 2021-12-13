using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TransformacionString
{
    public class StringHandler
    {

        public string Transform(string input, string transformation)
        {

            string[] funciones = transformation.Split("->");
            string resultado = string.Empty;

            foreach (string funcion in funciones)
            {
                switch (funcion)
                {
                    case "Lower":
                            resultado = MyToLower(input);
                        break;
                    case "Upper":
                        resultado = MyToUpper(input);
                        break;
                    case "Trim":
                        resultado = MyTrim(input);
                        break;
                    case "Ltrim":
                        resultado = MyLTrim(input);
                        break;
                    case "Rtrim":
                        resultado = MyRTrim(input);
                        break;
                    case "Pack":
                        resultado = MyPack(input);
                        break;
                    case "Pascal":
                        resultado = input.ToLower();//MOdificar
                        break;
                    case "Camel":
                        resultado = input.ToLower();//MOdificar
                        break;
                    case "Title":
                        resultado = input.ToLower();//MOdificar
                        break;
                    case "Snake":
                        resultado = input.ToLower();//MOdificar
                        break;
                }
            }
            return resultado;
        }

        private string MyToLower(string input)
        {
            string result = string.Empty;

            foreach (char letra in input)
            {
                result = result + letra.ToString().ToLower();
            }
            return result;
        }

        private string MyToUpper(string input)
        {
            string result = string.Empty;

            foreach (char letra in input)
            {
                result = result + letra.ToString().ToUpper();
            }
            return result;
        }

        private string MyLTrim(string input)
        {
            if (String.IsNullOrEmpty(input[0].ToString()))
            {
                input = input.Remove(0);
            }

            return input;
        }

        private string MyRTrim(string input)
        {

            if (String.IsNullOrEmpty(input[input.Length - 1].ToString()))
            {
                input = input.Remove(input.Length - 1);
            }

            return input;
        }

        private string MyTrim(string input)
        {
            input = MyLTrim(input);

            input = MyRTrim(input);

            return input;
        }

        private string MyPack(string input)
        {
            string result = string.Empty;
            int inicio = input[0];
            int fin = input[input.Length - 1];

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i].ToString() == " " && i != inicio && i != fin)
                {
                    input = input.Remove(i);
                }
            }
            
            return input;
        }

        private string MyPascal(string input)
        {

            string result = string.Empty;
            int inicio = input[0];
            int fin = input[input.Length - 1];

            for (int i = 0; i < input.Length; i++)
            {
                if(i == inicio)
                {
                    //input = input.Replace()
                }

                if (input[i].ToString() == " " && i != inicio && i != fin)
                {
                    input = input.Remove(i);
                }
            }

            return input;
        }
    }
}

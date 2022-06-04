using System;
using System.Collections;
using System.Collections.Generic;

namespace BibliotecaPruebasUnitarias
{
    public class CalculadoraString
    {

        public int Add(string numeros)
        {
            int retorno = 0;

            if (!string.IsNullOrEmpty(numeros))
            {
                List<char> separators = new List<char>();
                separators.Add(',');
                separators.Add('\n');

                if (numeros.StartsWith("//"))
                {
                    separators.Add((char)numeros[2]);
                    numeros = numeros.Substring(3);
                }
                string[] arrayNumbers = numeros.Split(separators.ToArray());

                if (arrayNumbers.Length > 0)
                {
                    foreach (string numerosString in arrayNumbers)
                    {
                        if (int.Parse(numerosString) < 0)
                        {
                            throw new NegatioNoPermitidoException("Numeros negativo no permitivo fallo en el valor " + numerosString);
                        }
                        retorno += int.Parse(numerosString);
                    }
                }
            }         
            return retorno;
        }
    }
}

using System;
using System.Text;

namespace LEjercicioIntegrador
{
    public class Cliente
    {
        //fields

        private string _aliasParaIncognito;
        private string _nombre;
        private eTipoCliente _tipoDeCliente;

        //Methods

        private Cliente():this(eTipoCliente.SinTipo,"NN")
        {       
        }

        public Cliente(eTipoCliente tipoCliente):this(tipoCliente,"NN")
        {      
        }

        public Cliente(eTipoCliente tipoCliente, string nombre)
        {
            this._nombre = nombre;
            this._aliasParaIncognito = "Sin alias";
            this._tipoDeCliente = tipoCliente;
        }

        private void CrearAlias()
        {
            Random rdn = new Random();
            int alias = rdn.Next(1000, 9999);
            this._aliasParaIncognito = $"{alias}{this._tipoDeCliente}";
        }

        public string GetAlias()
        {
            if (this._aliasParaIncognito == "Sin alias")
            {
                this.CrearAlias();
            }           
            return this._aliasParaIncognito;
        }

        public string RetornarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Nombre: {this._nombre}")
                .AppendLine($"Tipo: {this._tipoDeCliente}")
                .AppendLine($"Alias: {this.GetAlias()}");

            return sb.ToString();
        }

        public static string RetornarDatos(Cliente unCliente)
        {
            return unCliente.RetornarDatos();
        }
    }
}

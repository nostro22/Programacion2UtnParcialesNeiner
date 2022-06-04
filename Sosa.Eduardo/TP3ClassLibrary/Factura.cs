using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3ClassLibrary
{
    public class Factura : ICargaImpositiva<Persona>
    {
        private int numeroFactura;
        private int compradorId;
        private List<Producto> listProductos;
        private float total;
        private float descuento;
        private eTipoPago tipoPago;

        public eTipoPago TipoPago
        {
            get
            {
                return tipoPago;
            }

            set
            {
                tipoPago = value;
            }
        }
        public Factura()
        {
        }

        public Factura(int numeroFactura, Persona comprador, List<Producto> productos, eTipoPago tipoPago)
        {
            this.numeroFactura = numeroFactura;
            this.compradorId = comprador.Dni;
            if (tipoPago == eTipoPago.all)
            {
                this.tipoPago = eTipoPago.efectivo;
            }
            this.tipoPago = tipoPago;
            this.descuento = CalcularBonificaciones(comprador);
            if (productos is not null && productos.Count > 0)
            {
                this.total = Producto.CalcularTotal(productos, descuento);
            }
            else
            {
                this.listProductos = new List<Producto>();
                this.total = 0;
            }
        }

        public int NumeroFactura
        {
            get
            {
                return numeroFactura;
            }

            set
            {
                numeroFactura = value;
            }
        }

        public int CompradorId
        {
            get
            {
                return compradorId;
            }

            set
            {
                compradorId = value;
            }
        }

        public List<Producto> ListaProductos
        {
            get
            {
                return listProductos;
            }

            set
            {
                listProductos = value;
            }
        }

        public float Total
        {
            get
            {
                return total;
            }

            set
            {
                total = value;
            }
        }

        public float Descuento
        {
            get
            {
                return descuento;
            }

            set
            {
                descuento = value;
            }
        }

     

        public float CalcularBonificaciones(Persona comprador)
        {

            descuento = 0;

            if (comprador is Afiliado)
            {
                switch (((Afiliado)comprador).TipoVendendor)
                {
                    case eTipoAfiliado.trainee:
                        descuento = 0.1f;
                        break;
                    case eTipoAfiliado.junior:
                        descuento = 0.15f;
                        break;
                    case eTipoAfiliado.senior:
                        descuento = 0.2f;
                        break;
                }
            }
            switch (tipoPago)
            {
                case eTipoPago.efectivo:
                case eTipoPago.debito:
                    descuento += 0.1f;
                    break;
                case eTipoPago.credito:
                    descuento -= 0.1f;
                    break;
            }

            return descuento;
        }

        public float CalcularImpuesto(Persona comprador)
        {
            float impuesto = 0;

            if (comprador is Cliente)
            {
                switch (((Cliente)comprador).TipoCliente)
                {

                    case EtipoCliente.particular:
                    case EtipoCliente.monotributo:
                        impuesto = 0.21f;
                        break;

                    case EtipoCliente.responsable_Inscrito:
                        impuesto = 0;
                        break;
                }
            }
            return impuesto;
        }

        public static Factura operator +(Factura factura, Producto UnProducto)
        {
            
            factura.AddProducto(UnProducto,UnProducto.Cantidad);
            return factura;
           
        }

        public bool AddProducto(Producto unProducto, int cantidadQueDeseaAgregar)
        {
            bool agregadoConExito = false;
            if (unProducto != null && unProducto.Cantidad>0 && cantidadQueDeseaAgregar >0)
            {

                int cantidadAgregable = 0;
                if (cantidadQueDeseaAgregar > unProducto.Cantidad)
                {
                    cantidadAgregable = unProducto.Cantidad;
                }
                else
                {
                    cantidadAgregable = cantidadQueDeseaAgregar;
                }                
            
                if (listProductos.Contains(unProducto))
                {
                    foreach (Producto item in this.listProductos)
                    {
                        if (unProducto.Equals(item))
                        {
                            
                            unProducto.Cantidad += cantidadAgregable;
                            unProducto.Cantidad -=cantidadAgregable;
                            agregadoConExito = true;
                            break;
                        }
                    }
                }
                else
                {
                    listProductos.Add(unProducto);
                    agregadoConExito = true;
                }
            }
            return agregadoConExito;        
        }

    }


}

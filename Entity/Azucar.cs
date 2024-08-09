using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Azucar : AgregadoDecorator
    {
        public Azucar(BebidaComponent drink) : base(drink)
        {
        }

        public override double Costo => bebida.Costo + 5;

        public override string Descripcion => bebida.Descripcion + " con Azucar";
    }
}

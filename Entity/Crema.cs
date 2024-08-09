using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class Crema : AgregadoDecorator
    {
        public Crema(BebidaComponent drink) : base(drink)
        {

        }

        public override double Costo => bebida.Costo + 10;

        public override string Descripcion => bebida.Descripcion + " con Crema";
    }
}

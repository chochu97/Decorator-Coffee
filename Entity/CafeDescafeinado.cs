using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public class CafeDescafeinado : BebidaComponent
    {
        public override double Costo => 200;

        public override string Descripcion => "Cafe descafeinado";
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    public abstract class AgregadoDecorator : BebidaComponent
    {
        protected BebidaComponent bebida;

        public AgregadoDecorator(BebidaComponent drink)
        {
            bebida = drink;
        }
    }
}

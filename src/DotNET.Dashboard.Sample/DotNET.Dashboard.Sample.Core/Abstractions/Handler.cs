using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNET.Dashboard.Sample.Core.Abstractions
{
    public abstract class Handler<TQuery, TResponse> 
        where TResponse : Response 
        where TQuery : Query
    {

        public abstract Task<TResponse> Run(TQuery query);
    }

    public abstract class Handler<TCommand>
       where TCommand : Command
    {

        public abstract Task Run(TCommand command);
    }
}

using FluentValidation.Results;
using Ribeiro.MF7.Api.Controllers.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Ribeiro.MF7.Controllers.Tests.Common
{
    public class ApiControllerBaseFake : ApiControllerBase
    {
        public IHttpActionResult HandleCallback<TSuccess>(Func<TSuccess> func)
        {
            return base.HandleCallback(func);
        }

        public IHttpActionResult HandleQuery<TResult>(IQueryable<TResult> query)
        {
            return base.HandleQuery(query);
        }

        public IHttpActionResult HandleQueryable<TSource, TDestination>(IQueryable<TSource> query)
        {
            return base.HandleQueryable<TSource, TDestination>(query);
        }

        public IHttpActionResult HandleValidationFailure<T>(IList<T> validationFailure) where T : ValidationFailure
        {
            return base.HandleValidationFailure<T>(validationFailure);
        }
    }

    public class ApiControllerBaseDummy
    {
    }
}

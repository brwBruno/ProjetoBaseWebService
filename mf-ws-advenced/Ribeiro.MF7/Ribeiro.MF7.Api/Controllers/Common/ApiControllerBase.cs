using AutoMapper;
using AutoMapper.QueryableExtensions;
using FluentValidation.Results;
using Ribeiro.MF7.Api.Exceptions;
using Ribeiro.MF7.Domain.Exceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Http;

namespace Ribeiro.MF7.Api.Controllers.Common
{
    public class ApiControllerBase : ApiController
    {
        protected IHttpActionResult HandleCallback<TSucess>(Func<TSucess> func)
        {
            try
            {
                var ok = Ok(Mapper.Map<TSucess>(func()));
                return ok;
            }
            catch (Exception e)
            {
                return HandleFailure(e);
            }
        }

        protected IHttpActionResult HandleCallback<TSource, TDestination>(Func<TSource> func)
        {
            try
            {
                var ok = Ok(Mapper.Map<TDestination>(func()));
                return ok;
            }
            catch (Exception e)
            {
                return HandleFailure(e);
            }
        }

        protected IHttpActionResult HandleQuery<TResult>(IQueryable<TResult> query)
        {
            return Ok(query.ToList());
        }

        protected IHttpActionResult HandleQueryable<TSource, TDestination>(IQueryable<TSource> query)
        {
            return Ok(query.ProjectTo<TDestination>().ToList());
        }

        protected IHttpActionResult HandleFailure<T>(T exceptionToHandle) where T : Exception
        {
            var exceptionPayload = ExceptionPayload.New(exceptionToHandle);
            var exception = exceptionToHandle is BusinessException ?
                Content(HttpStatusCode.BadRequest, exceptionPayload) :
                Content(HttpStatusCode.InternalServerError, exceptionPayload);

            return exception;
        }

        protected IHttpActionResult HandleValidationFailure<T>(IList<T> validationFailure) where T : ValidationFailure
        {
            return Content(HttpStatusCode.BadRequest, validationFailure);
        }
    }
}
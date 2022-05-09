using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Straumann.Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathOperationsController : ControllerBase
    {
        private readonly MathContext _context;
        public MathOperationsController(MathContext context)
        {
            this._context = context;
        }
        /// <summary>
        /// Addition
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        [HttpGet("add")]
        public int Add([FromHeader] int num1, [FromHeader] int num2)
        {
                var entity = new MathOperationsEntity()
                {
                    OperationType = MathOperationsType.Add.ToString(),
                    Num1 = num1,
                    Num2 = num2,
                    Result = (num1 + num2),
                    CreatedOn = DateTime.UtcNow,
                };

                _context.MathOperationsEntities.Add(entity);
                _context.SaveChanges();
           

            return entity.Result;
        }
        /// <summary>
        /// Subtraction
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        [HttpGet("subtract")]
        public int Subtract([FromHeader] int num1, [FromHeader] int num2)
        {
            var entity = new MathOperationsEntity()
            {
                OperationType = MathOperationsType.Subtract.ToString(),
                Num1 = num1,
                Num2 = num2,
                Result = (num1 - num2),
                CreatedOn = DateTime.UtcNow,
            };

            _context.MathOperationsEntities.Add(entity);
            _context.SaveChanges();

            return entity.Result;
        }
        /// <summary>
        /// Multiplication 
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        [HttpGet("multiple")]
        public int Multiple([FromHeader] int num1, [FromHeader] int num2)
        {
            var entity = new MathOperationsEntity()
            {
                OperationType = MathOperationsType.Multiple.ToString(),
                Num1 = num1,
                Num2 = num2,
                Result = (num1 * num2),
                CreatedOn = DateTime.UtcNow,
            };

            _context.MathOperationsEntities.Add(entity);
            _context.SaveChanges();
            
            return entity.Result;
        }
        /// <summary>
        /// Division
        /// </summary>
        /// <param name="num1"></param>
        /// <param name="num2"></param>
        /// <returns></returns>
        [HttpGet("divide")]
        public int Divide([FromHeader] int num1, [FromHeader] int num2)
        {
            var entity = new MathOperationsEntity()
            {
                OperationType = MathOperationsType.Division.ToString(),
                Num1 = num1,
                Num2 = num2,
                Result = (num1 / num2),
                CreatedOn = DateTime.UtcNow,
            };

            _context.MathOperationsEntities.Add(entity);
            _context.SaveChanges();

            return entity.Result;

        }

        /// <summary>
        /// API to retrieve last 10 operation history.
        /// </summary>
        /// <returns></returns>
        [HttpGet("getOpration")]
        public List<MathOperationsEntity> Opration()
        {
                var result = _context.MathOperationsEntities.OrderByDescending(x=>x.CreatedOn).Take(10).ToList();
                return result;
            
        }
    }
}

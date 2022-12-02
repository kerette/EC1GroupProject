using AutoMapper;
using AutoMapper.Internal;
using AutoMapper.QueryableExtensions;
using EC1GroupProject.Dtos;
using EC1GroupProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace EC1GroupProject.Api
{
    public class PaymentsController : ApiController
    {
        private ApplicationDbContext _context;
        // GET api/<controller>
        public IEnumerable<PaymentDto> GetPayments()
        {
            return _context.Payments
                .ToList()
                .Select(Mapper.Map<Payment, PaymentDto>);
        }

        // GET api/<controller>/5
        public IHttpActionResult GetPayment(string account)
        {
            var payment = _context.Payments.SingleOrDefault(c => c.AccountNumber == account);

            if (payment == null)
                return NotFound();

            return Ok(Mapper.Map<Payment, PaymentDto>(payment));
        }

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult MakePayment(PaymentDto paymentDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var payment = Mapper.Map<PaymentDto, Payment>(paymentDto);
            _context.Payments.Add(payment);
            _context.SaveChanges();

            paymentDto.Id = payment.Id;

            return Created(new Uri(Request.RequestUri + "/" + payment.Id), paymentDto);
        }

        // PUT api/<controller>/5
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<controller>/5
        public void Delete(int id)
        {
        }
    }
}
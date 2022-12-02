using AutoMapper;
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
    public class AccountsController : ApiController
    {
        private ApplicationDbContext _context;
        // GET api/<controller>

        // GET api/<controller>/5
        public IHttpActionResult GetAccount(string accountNumber)
        {
            var account = _context.Accounts.SingleOrDefault(c => c.AccountNumber == accountNumber);

            if (account == null)
                return NotFound();

            return Ok(Mapper.Map<AccountModel, AccountDto>(account));
        }

        // POST api/<controller>
        [HttpPost]
        public IHttpActionResult CreateAccount(AccountDto accountDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            var account = Mapper.Map<AccountDto, AccountModel>(accountDto);
            _context.Accounts.Add(account);
            _context.SaveChanges();

            accountDto.AccountNumber = account.AccountNumber;
            return Created(new Uri(Request.RequestUri + "/" + account.AccountNumber), accountDto);
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
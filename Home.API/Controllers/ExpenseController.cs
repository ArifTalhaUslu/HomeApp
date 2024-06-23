using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace Home.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseController : ControllerBase
    {
        private protected IExpenseService _expenseService;
        public ExpenseController(IExpenseService expenseService)
        {
            _expenseService = expenseService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            var result = _expenseService.GetList();
            return Ok(result);
        }
        [HttpGet]
        public IActionResult Get(Guid id)
        {
            var result = _expenseService.GetById(id);
            return Ok(result);
        }
        [HttpPost]
        public IActionResult Add()
        {
            return Ok();
        }
        [HttpPut]
        public IActionResult Update()
        {
            return Ok();
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            var result = _expenseService.Delete(id);
            return !result ? throw new System.Web.Http.HttpResponseException(new HttpResponseMessage(HttpStatusCode.NotFound)
            {
                Content = new StringContent("Not Found"),
                ReasonPhrase = "Expense Not Found"
            }) : Ok();
        }
    }
}

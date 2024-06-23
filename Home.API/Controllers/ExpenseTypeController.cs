using BLL.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Home.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExpenseTypeController : ControllerBase
    {
        private protected IExpenseTypeService _expenseTypeService;
        public ExpenseTypeController(IExpenseTypeService expenseTypeService)
        {
            _expenseTypeService = expenseTypeService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
        [HttpGet]
        public IActionResult Get(string id)
        {
            return Ok();
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
        public IActionResult Delete(string id)
        {
            return Ok();
        }
    }
}

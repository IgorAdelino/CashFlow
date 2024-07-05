using CashFlow.Application.UseCases.Expenses.Register;
using CashFlow.Communication.Requests;

namespace Validators.Tests.Expenses.Register
{
    public class RegisterExpenseValidatorTests
    {
        [Fact]
        public void Success()
        {
            var validator = new RegisterExpenseValidator();
            var request = new RequestRegisterExpenseJson
            {
                Amount = 100,
                Date = DateTime.Now.AddDays(-1),
                Description = "description",
                Title = "title",
                PaymentType = CashFlow.Communication.Enums.PaymentType.Cash
            };

            var result = validator.Validate(request);

            Assert.True(result.IsValid);

        }
    }
}

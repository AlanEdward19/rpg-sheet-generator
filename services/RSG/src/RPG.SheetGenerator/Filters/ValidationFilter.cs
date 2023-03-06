using Microsoft.AspNetCore.Mvc.Filters;

namespace RPG.SheetGenerator.API.Filters;
public class ValidationFilter : IActionFilter
    {
        public void OnActionExecuting(ActionExecutingContext context)
        {
            if (!context.ModelState.IsValid)
            {
                var errorMessages = context.ModelState
                    .SelectMany(ms => ms.Value.Errors)
                    .Select(e => e.ErrorMessage)
                    .ToList();

                context.Result = new BadRequestObjectResult(errorMessages);
            }
        }

        public void OnActionExecuted(ActionExecutedContext context)
        {

        }
    }
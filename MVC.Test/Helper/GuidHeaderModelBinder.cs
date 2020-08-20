using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC.Test.Helper
{
    public class GuidHeaderModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext.ModelType != typeof(Guid)) return Task.CompletedTask;
            var headerName = bindingContext.ModelName;
            var stringValue = bindingContext.HttpContext.Request.Form[headerName];
            bindingContext.ModelState.SetModelValue(bindingContext.ModelName, stringValue, stringValue);

            // Attempt to parse the guid                
            if (Guid.TryParse(stringValue, out var valueAsGuid))
            {
                bindingContext.Result = ModelBindingResult.Success(valueAsGuid);
            }

            return Task.CompletedTask;
        }
    }
}

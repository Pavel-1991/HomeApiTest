using FluentValidation;
using FluentValidation.Validators;
using HomeApi.Contracts.Models.Devices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeApi.Contracts.Validation
{
    public class DeleteDeviceRequestValidation : AbstractValidator<DeleteDeviceRequest>
    {
        public DeleteDeviceRequestValidation()
        {
            RuleFor(x => x.Name).NotEmpty();
        }


    }
}

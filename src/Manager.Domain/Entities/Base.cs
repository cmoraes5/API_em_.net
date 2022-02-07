using FluentValidation;
using FluentValidation.Results;
using System.Collections.Generic;
using System.Text;

namespace Manager.Domain.Entities{

    public abstract class Base{
        public long Id { get; set; }

        internal List<string> _errors;
        public IReadOnlyCollection<string> Errors => _errors; // ==> Encapsulamento, substituindo o propfull

        public abstract bool Validate();
    }
}
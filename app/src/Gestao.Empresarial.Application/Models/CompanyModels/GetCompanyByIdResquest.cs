using System;
using System.ComponentModel.DataAnnotations;

namespace Gestao.Empresarial.Application.Models.CompanyModels
{
    public class GetCompanyByIdResquest
    {
        [Required]
        public Guid Id { get; set; }
    }
}

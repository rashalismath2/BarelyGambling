using BarelyGambling.API.Dto;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BarelyGambling.API.ValidationAttributes
{
    public class ValidateCreateTeams : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var teams = (List<TeamDto>)value;
            var teamMembers = new List<string>();
            foreach (var team in teams)
            {
                foreach (var teamMember in team.TeamMembers)
                {
                    if (teamMembers.SingleOrDefault(member => teamMember.UserId == member) != null) 
                        return new ValidationResult("Team members should be unique"); 
                    teamMembers.Add(teamMember.UserId);
                }
            }
            return ValidationResult.Success;
        }
    }
}

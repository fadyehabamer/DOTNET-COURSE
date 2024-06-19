﻿using Eticket.Models;
namespace Eticket.ViewModels
{
    public class ActorVM
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public string Bio { get; set; }
        public string ProfilePicture { get; set; }

        public string News { get; set; }

        public List<MovieVM> Movies { get; set; }
    }
}

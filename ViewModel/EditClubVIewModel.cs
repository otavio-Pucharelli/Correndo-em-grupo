﻿using CorrendoEmGrupo.Data.Enum;
using CorrendoEmGrupo.Models;

namespace CorrendoEmGrupo.ViewModel
{
    public class EditClubVIewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int AddressId { get; set; }
        public Address Address { get; set; }
        public IFormFile Image { get; set; }
        public string? URL { get; set; }
        public ClubCategory ClubCategory { get; set; }
    }
}

﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Application.DTO
{
    public class GetUserDto
    {
        public int Id { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string Username { get; set; }

        public string Email { get; set; }

        public string Role { get; set; }


    }
}

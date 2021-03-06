﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Connection.Entities;

namespace av_challenge_api.Models
{
    public class UsuarioResponse : IResponse<UsuarioEntity>
    {

        public string Resultado { get; set; } = "N";

        public string Mensaje { get; set; } = "";

        public List<UsuarioEntity> Datos { get; set; } = new List<UsuarioEntity>();

    }

}

﻿using senai.Filmes.WebApi.Domains;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace senai.Filmes.WebApi.Interfaces
{
    /// <summary>
    /// Interface responsável pelo repositório Genero
    /// </summary>
    interface IGeneroRepository
    {
        /// <summary>
        /// Lista todos os gêneros
        /// </summary>
        /// <returns>Retorna uma lista de gêneros</returns>
        List<GeneroDomain> Listar();
         GeneroDomain Cadastrar(GeneroDomain Genero);
        GeneroDomain Atualizar(int IdGenero, GeneroDomain Genero);
        GeneroDomain Deletar(int IdGenero, GeneroDomain Genero);
    }
}

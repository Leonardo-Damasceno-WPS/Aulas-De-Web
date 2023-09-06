using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Aula_3.Models
{
    public class DiscoDados
    {
        public List<Disco> listaDisco = new List<Disco>();
        public DiscoDados()
        {
            listaDisco.Add(new Disco
            {
                disco = "Dois",
                artista = "Legião Urbana",
                faixas = "13"
            });
            listaDisco.Add(new Disco
            {
                disco = "Shoot to Thrill",
                artista = "ACDC",
                faixas = "13"
            });
            listaDisco.Add(new Disco
            {
                disco = "Thriller",
                artista = "Michael Jackson",
                faixas = "13"
            });
        }
        public void CriaDiscos(Disco discos)
        {
            listaDisco.Add(discos);
        }
    }
}
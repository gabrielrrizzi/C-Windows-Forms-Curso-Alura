using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;
using CursoWindowsFormsBiblioteca.Databases;

namespace CursoWindowsFormsBiblioteca.Cliente
{
    public class Cliente
    {
        public class Unit
        {
            [Required(ErrorMessage = "Código do cliente é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Código do Cliente somente aceita valores numéricos.")]
            [StringLength(6, MinimumLength = 6, ErrorMessage = "Código do Cliente deve ter 6 digitos")]
            public string ID { get; set; }

            [Required(ErrorMessage = "Nome do cliente é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome do cliente deve ter no máximo 50 caracteres.")]
            public string Name { get; set; }

            [StringLength(50, ErrorMessage = "Nome do pai deve ter no máximo 50 caracteres.")]
            public string NomeDoPai { get; set; }

            [Required(ErrorMessage = "Nome da mãe é obrigatório")]
            [StringLength(50, ErrorMessage = "Nome da mãe deve ter no máximo 50 caracteres.")]
            public string NomeDaMae { get; set; }
            public bool NaoTemPai { get; set; }
            [Required(ErrorMessage = "CPF é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CPF somente aceita valores numéricos.")]
            [StringLength(11, MinimumLength = 11, ErrorMessage = "CPF deve ter 11 digitos")]
            public string CPF { get; set; }
            [Required(ErrorMessage = "Genero é obrigatório")]
            public int Genero { get; set; }
            [Required(ErrorMessage = "CPF é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "CEP somente aceita valores numéricos.")]
            [StringLength(8, MinimumLength = 8, ErrorMessage = "CEP deve ter 8 digitos")]
            public string CEP { get; set; }
            [Required(ErrorMessage = "Logradouro é obrigatório")]
            [StringLength(100, ErrorMessage = "Logradouro deve ter no máximo 100 caracteres.")]
            public string Logradouro { get; set; }
            [Required(ErrorMessage = "Complemento é obrigatório")]
            [StringLength(100, ErrorMessage = "Complemento deve ter no máximo 100 caracteres.")]
            public string Complemento { get; set; }
            [Required(ErrorMessage = "Bairro é obrigatório")]
            [StringLength(50, ErrorMessage = "Bairro deve ter no máximo 50 caracteres.")]
            public string Bairro { get; set; }
            [Required(ErrorMessage = "Cidade é obrigatório")]
            [StringLength(50, ErrorMessage = "Cidade deve ter no máximo 50 caracteres.")]
            public string Cidade { get; set; }
            [Required(ErrorMessage = "Estado é obrigatório")]
            [StringLength(50, ErrorMessage = "Estado deve ter no máximo 50 caracteres.")]
            public string Estado { get; set; }
            [Required(ErrorMessage = "Telefone é obrigatório")]
            [RegularExpression("([0-9]+)", ErrorMessage = "Numero do telefone somente aceita valores numéricos.")]
            public string Telefone { get; set; }

            public string Profissao { get; set; }
            [Required(ErrorMessage = "Renda familiar é obrigatório")]
            [Range(0, double.MaxValue, ErrorMessage = "Renda familiar deve ser um valor positivo")]
            public double RendaFamiliar { get; set; }

            public void ValidaClasse()
            {
                ValidationContext context = new ValidationContext(this, serviceProvider: null, items: null);
                List<ValidationResult> results = new List<ValidationResult>();
                bool isValid = Validator.TryValidateObject(this, context, results, true);

                if (isValid == false)
                {
                    StringBuilder sbrErrors = new StringBuilder();
                    foreach (var validationResult in results)
                    {
                        sbrErrors.AppendLine(validationResult.ErrorMessage);
                    }
                    throw new ValidationException(sbrErrors.ToString());
                }
            }

            public void ValidaComplemento()
            {
                if(this.NomeDoPai == this.NomeDaMae)
                {
                    throw new Exception("Nome do Pai e da Mãe não podem ser iguais");
                }

                if(this.NaoTemPai == false)
                {
                    if(this.NomeDoPai == "")
                    {
                        throw new Exception("Nome do Pai não pode estar vazio quando a propriedade Pai desconhecido não estiver marcada");
                    }
                }
                bool valideCPF = Cls_Uteis.Valida(this.CPF);
                if(valideCPF == false)
                {
                    throw new Exception("CPF inválido");
                }
            }

            #region "CRUD DO FICHARIO"

            public void IncluirFichario(string Conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);

                Fichario fichario = new Fichario(Conexao);
                if (fichario.status)
                {
                    fichario.Incluir(this.ID, clienteJson);
                    if (!fichario.status)
                    {
                        throw new Exception("Err: " + fichario.message);
                    }
                   
                }
                else
                {
                    throw new Exception("Err: " + fichario.message);
                }

            }

            public Unit BuscarFichario(string Id,string Conexao)
            {

                Fichario fichario = new Fichario(Conexao);
                if (fichario.status)
                {
                    string clienteJson = fichario.Buscar(Id);
                    return  Cliente.DesSerializedClassUnit(clienteJson);

                }
                else
                {
                    throw new Exception("Erro na conexão");
                }


            }

            public void AlterarFichario(string Conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario f = new Fichario(Conexao);
                if (f.status)
                {
                    f.Alterar(this.ID, clienteJson);
                    if (!f.status)
                    {
                        throw new Exception("Err: " + f.message);
                    }
                }
                else
                {
                    throw new Exception("Err: " + f.message);
                }

            }

            public void ApagarFichario(string Conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario f = new Fichario(Conexao);
                if (f.status)
                {
                    f.Apagar(this.ID);
                    if (!f.status)
                    {
                        throw new Exception("Err: " + f.message);
                    }
                }
                else
                {
                    throw new Exception("Err: " + f.message);
                }



            }

            public List<string> Buscar(string Conexao)
            {
                string clienteJson = Cliente.SerializedClassUnit(this);
                Fichario f = new Fichario(Conexao);
                if (f.status)
                {
                    List<string> TodosJson = f.BuscarTodos();
                    return TodosJson;
                }
                else
                {
                    throw new Exception("Err: " + f.message);
                }
            }



            #endregion

        }

        public class List
        {
            public List<Unit> ListUnit { get; set; }
        }
        public static Unit DesSerializedClassUnit(string vJson)
        {
            return JsonConvert.DeserializeObject<Unit>(vJson);
        }

        public static string SerializedClassUnit(Unit unit)
        {
            return JsonConvert.SerializeObject(unit);
        }

        

    }
}

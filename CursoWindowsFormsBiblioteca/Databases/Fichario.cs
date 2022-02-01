using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CursoWindowsFormsBiblioteca.Databases
{
    public class Fichario
    {
        public string diretorio { get; set; }
        public string message { get; set; }
        public bool status { get; set; }


        public Fichario(string Diretorio)
        {
            try
            {
                status = true;
                if (!Directory.Exists(Diretorio))
                {
                    Directory.CreateDirectory(Diretorio);
                }

                diretorio = Diretorio;
                message = "Conexão com o fichario criada com sucesso.";
            }catch (Exception ex)
            {
                message = "Conexão com o fichario criada com erro. " + ex.Message;
               status = false;
            }
        }
        public void Incluir(string Id, string jsonUnit)
        {
            try
            {
                status = true;
                if (File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    message = "Inclusão não permitida porque o indentificar já existe" + Id;
                }
                else
                {
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    message = "Inclusão efetuada com sucesso: " + Id;
                }
            }
            catch(Exception ex)
            {
                message = "Conexão com o fichario criada com erro. " + ex.Message;
                status = false;
            }

        }

        public string Buscar(string Id)
        {
            status = true;
            try
            {
                if (!File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    message = "Identificador não existente: " + Id;
                }
                else
                {
                   string conteudo = File.ReadAllText(diretorio + "\\" + Id + ".json");
                    message = "Aquivo encontrado: " + Id;
                    return conteudo;
                }


            }
            catch (Exception ex)
            {
                message = "Erro ao buscar o conteúdo do identificador. " + ex.Message;
            }
            return "";
        }

        public void Apagar(string Id)
        {
            status = true;
            try
            {
                if (!File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    message = "Identificador não existente: " + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    message = "Aquivo excluído com sucesso. Identificador : " + Id;
                }


            }
            catch (Exception ex)
            {
                message = "Erro ao buscar o conteúdo do identificador. " + ex.Message;
            }
        }

        public void Alterar(string Id, string jsonUnit)
        {
            try
            {
                status = true;
                if (!File.Exists(diretorio + "\\" + Id + ".json"))
                {
                    status = false;
                    message = "Alteração não permitida porque o indentificar não existe" + Id;
                }
                else
                {
                    File.Delete(diretorio + "\\" + Id + ".json");
                    File.WriteAllText(diretorio + "\\" + Id + ".json", jsonUnit);
                    message = "Alteração efetuada com sucesso: " + Id;
                }
            }
            catch (Exception ex)
            {
                message = "Conexão com o fichario criada com erro. " + ex.Message;
                status = false;
            }

        }
        public List<string> BuscarTodos()
        {
            status = true;
            List<string> List = new List<string>();

            try
            {
                var Arquivos = Directory.GetFiles(diretorio, "*.json");
                for(int i = 0; i<= Arquivos.Length - 1; i++)
                {
                    string conteudo = File.ReadAllText(Arquivos[i]);
                    List.Add(conteudo);
                }
                return List;
            }
            catch (Exception ex)
            {
                status=false;
                message = "Erro ao buscar o conteúdo do identificador. " + ex.Message;
            }
            return null;
        }


    }
}

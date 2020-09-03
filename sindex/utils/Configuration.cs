using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Media.Animation;

namespace sindex.utils
{
    public class Configuration
    {
        public List<User> users;
        public int currentUser { get; set; }
        public int currentConfiguration { get; set; }

        public Configuration()
        {
            if (users == null)
            {
                users = new List<User>();
            }

            currentUser = -1;
            currentConfiguration = -1;
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void LoadFromJson(string json)
        {
            Configuration configuration = JsonConvert.DeserializeObject<Configuration>(json);
            this.users = configuration.users;
        }

        public void AddUser(User user)
        {

            if(getUserIndex(user.user) != -1)
            {
                throw new Exception("Usuário já cadastrado");
            }

            users.Add(user);
        }

        public int getUserIndex(string user)
        {
            int _out = -1;

            if (users == null) return -1;

            for (int i= 0; i < users.Count; i++)
            {
                if (users[i].user == user)
                {
                    return i;
                }
            }

            return _out;
        }

        public void Login(string user, string senha)
        {
            int i = getUserIndex(user);

            if (i < 0) throw new Exception("Credenciais inválidas!");

            if (users[i].Login(senha))
            {
                this.currentUser = i;
            } else
            {
                throw new Exception("Credenciais inválidas!");
            }
        }
    }

    public class User
    {
        public string user { get; set; }
        public string password { get; set; }
        public string passwordTwo { get; set; }
        public string email { get; set; }
        public bool darkTheme { get; set; }
        public List <Enviroment> enviroments { get; set; }

        public bool Login(string password)
        {
            return this.password == password;
        }

        public User()
        {

        }

        public User(string user, string password, string passwordTwo, string email, bool darkTheme)
        {
            if (password != passwordTwo)
            {
                throw new Exception("Senha e confirmação de senha não coincidem!");
            }

            if (password.Length < 6)
            {
                throw new Exception("Senha deve conter no mínimo seis caracteres!");
            }

            if (String.IsNullOrEmpty(user))
            {
                throw new Exception("Informe o usuário!");
            }

            if (String.IsNullOrEmpty(password))
            {
                throw new Exception("Informe a senha!");
            }

            if (String.IsNullOrEmpty(email))
            {
                throw new Exception("Informe o e-mail!");
            }

            if (!ValidarEmail(email))
            {
                throw new Exception("E-mail inválido!");
            }

            this.user = user;
            this.password = password;
            this.email = email;
            this.darkTheme = darkTheme;
            enviroments = new List<Enviroment>();
        }

        public void AddEnviroment(Enviroment env)
        {
            if (enviroments == null)
            {
                enviroments = new List<Enviroment>();
            }

            enviroments.Add(env);
        }

        public void RemoveEnviroment(int index)
        {
            enviroments.RemoveAt(index);
        }

        public List<Enviroment> GetEnviroments()
        {
            return this.enviroments;
        }

        public void UpdateEnviroment(int index, Enviroment env)
        {
            enviroments[index].database = env.database;
            enviroments[index].server = env.server;
            enviroments[index].user = env.user;
            enviroments[index].password = env.password;
            enviroments[index].database = env.database;
        }

        public bool ValidarEmail(string email)
        {
            try
            {
                Regex expressaoRegex = new Regex(@"\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}");

                if (expressaoRegex.IsMatch(email))
                {
                    // o email é valido
                    return true;
                }
                else
                {
                    // o email é inválido
                    return false;
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void AtualizarSenha(string senhaNova){
            this.password = senhaNova;
        }
    }

    public class Enviroment
    {
        public string name { get; set; }
        public string server { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string database { get; set; }

        public string GetConnectionString(string database)
        {
            return String.Format("Data Source = {0}; Initial Catalog = {1}; User ID = {2}; Password = {3};", this.server, database, this.user, this.password);
        }

        public Credentials GetCredentials()
        {
            return new Credentials(this.user, this.password, this.server);
        }

        public string GetDatabase()
        {
            return this.database;
        }
    }
}

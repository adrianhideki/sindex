using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sindex.model
{
    public class ConfigurationFile
    {
        List<User> users;

        public ConfigurationFile()
        {
            if (users == null)
            {
                users = new List<User>();
            }
        }

        public string ToJson()
        {
            return JsonConvert.SerializeObject(this);
        }

        public void LoadFromJson(string json)
        {
            ConfigurationFile configuration = JsonConvert.DeserializeObject<ConfigurationFile>(json);
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
    }

    public class User
    {
        public string user { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public bool darkTheme { get; set; }
        List <Enviroment> enviroments { get; set; }

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

            this.user = user;
            this.password = password;
            this.email = email;
            this.darkTheme = darkTheme;
            enviroments = new List<Enviroment>();
        }

        public void AddEnviroment(Enviroment env)
        {
            enviroments.Add(env);
        }

        public void RemoveEnviroment(int index)
        {
            enviroments.RemoveAt(index);
        }

        public void UpdateEnviroment(int index, Enviroment env)
        {
            enviroments[index] = env;
        }
    }

    public class Enviroment
    {
        public string name { get; set; }
        public string server { get; set; }
        public string user { get; set; }
        public string password { get; set; }

        public string GetConnectionString(string database)
        {
            return String.Format("Data Source = {0}; Initial Catalog = {1}; User ID = {2}; Password = {3};", this.server, database, this.user, this.password);
        }
    }
}

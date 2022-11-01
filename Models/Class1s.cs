namespace MVCProjects.Models
{
    public class Class1s
    {
        public Class1s(int? id, string player, string teams, string preferdfoot, string height, string weight, int salary, int age)
        {
            Id = id;
            this.player = player;
            this.teams = teams;
            this.preferdfoot = preferdfoot;
            Height = height;
            this.weight = weight;
            this.salary = salary;
            this.age = age;
        }
        public Class1s()
        {
            return;
        }

        public int? Id { get; set; }
            public string player { get; set; }
            public string teams { get; set; }
            public string preferdfoot { get; set; }
            public string Height { get; set; }
            public string weight { get; set; }
            public string nationality { get; set; }
            public string postion { get; set; }
            public int salary { get; set; }

            public int age { get; set; }
        }

    }


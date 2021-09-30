using System;

namespace Task1
{
    class Human
    {
        private string lastname;
        private string name;
        private string midlename;
        private string gender;
        private int age;
        private int minAge;
        private int maxAge;
        private float height;
        private float minHeight;
        private float maxHeight;
        private float weight;
        private float minWeight;
        private float maxWeight;
        private string[] status_list = { "rest", "sad", "happy", "laughs", "scared", "cry", "angry" };
        private string status;

        public Human()
        {
            lastname = "Ivanov";
            name = "Ivan";
            midlename = "Ivanovich";
            gender = "male";
            minAge = 18;
            maxAge = 125;
            age = 20;
            minHeight = 65;
            maxHeight = 255;
            height = 187.5f;
            maxWeight = 635;
            minWeight = 20;
            weight = 85.4f;
            status = status_list[0];
        }
        public Human(string lastname, string name, string midlename):this()
        {
            this.lastname = lastname;
            this.name = name;
            this.midlename = midlename;
        }
        public Human(string lastname,string name, string midlename, string gender, int age, float height, float weight):this(lastname, name, midlename)
        {
            if (age<=maxAge||age>=minAge)
                this.age = age;
            else this.age=minAge;
            this.gender = gender;
            if (age <= maxHeight || age >= minHeight)
                this.height = height;
            if (age <= maxWeight || age >= minWeight)
                this.weight = weight;
        }
        /// <summary>
        /// Set name and lastname of Human
        /// </summary>
        /// <param name="name">Human's name</param>
        /// <param name="lastname"> Human's lastname</param>
        public void SetNameLastname(string name, string lastname)
        {
            this.name = name;
            this.lastname = lastname;
        }
        public void SetName(string name)
        {
            this.name = name;
        }
        public void SetLastname(string lastname)
        {
            this.lastname = lastname;
        }
        public void SetMidlename(string midlename)
        {
            this.midlename = midlename;
        }
        public string GetLastname()
        {
            return lastname;
        }
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// Change Human's status: 0 - rest, 1 - sad, 2 - happy, 3 - laughs, 4 - scared, 5 - cry, 6 - angry
        /// </summary>
        /// <param name="i">Status: 0 - rest, 1 - sad, 2 - happy, 3 - laughs, 4 - scared, 5 - cry, 6 - angry</param>
        public void changeStatus(int i)
        {
            if (i >= 0 && i < 7) status = status_list[i];
            else status = status_list[0];
        }
        public void makeSad()
        {
            status = status_list[1];
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Person info:\nLastname: {lastname}\nName: {name}\nMidlename: {midlename}\nGender: {gender}\nAge: {age}\nHeight: {height}\nWeight: {weight}\nStatus: {status}");
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Human Sam = new Human("Kornienko", "Semen", "Ivanovich");
            Sam.ShowInfo();
            Sam.SetMidlename("Petrovich");
            Sam.SetLastname("Reddragon");
            Console.WriteLine($"\nHuman lastname: {Sam.GetLastname()}\nHuman name: {Sam.GetName()}\n");
            Sam.changeStatus(2);
            Sam.ShowInfo();

        }
    }
}

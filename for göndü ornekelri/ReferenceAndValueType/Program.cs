

//int sayi1 = 10;
//int sayi2 = 20;
//Console.WriteLine(sayi2);
//sayi2 = sayi1;
//sayi1 = 30;

//Console.WriteLine(sayi1);
//Console.WriteLine(sayi2);

//string[] name1 = new string[3] { "Abdullah", "Yasin", "Selman" };//AFDC27
//string[] name2 = new string[3] { "Demir", "Polat", "Sabaz" };//AFDC28//AFDC27
//name2 = name1;
//Console.WriteLine(name2[0]);


using System.Collections;

//string[] cities = new string[3] { "Diyarbakır", "Batman", "Sivas" };//ADF1

//ArrayList firstName = new ArrayList();
//firstName.Add("Abudllah");
//firstName.Add("Yasin");
//firstName.Add("Selman");
//firstName.Add("İbrahim");

//foreach (string s in firstName)
//{
//    Console.WriteLine(s);
//}
//firstName.Add('A');
//firstName.Add(34);
//Console.WriteLine("------------------------------------");
//for (int i = 0; i < firstName.Count; i++)
//{
//    Console.WriteLine(firstName[i]);
//}

List<int> list = new List<int>(); 
List<Patient> patients = new List<Patient>
{
    new Patient{Id=1,Name="Ahmet"},
    new Patient{Id=2,Name="Mehmet"}
}; 

Console.WriteLine(patients.AddRange);

 Patient Add(Patient patient)
{
    return patient;
}

 IEnumerable<Patient> AddRange(IEnumerable<Patient> patients)
{
    return patients;
}


list.Add(3);
list.Remove(4);
list.Clear();
list.Add(5);



string[] name = new string[3] { "Abdullah", "Yasin", "Selman" };//AFDC27

for (int i = 0; i < name.Length; i++)
{
    if (name[i] == "Selman")
    {
        name[i] = "";
    }
    Console.WriteLine(name[i]);
}


class Patient
{
    public int Id { get; set; }
    public string Name { get; set; }
}